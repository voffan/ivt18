import 'package:computers/database.dart';
import 'package:computers/forms/computer/computer_form_controller.dart';
import 'package:computers/models/status.dart';
import 'package:get/get.dart';
import 'package:uuid/uuid.dart';

class StatusFormController extends GetxController {
  
  Status status = Status();

  String name;

  bool editing = false;

  @override
  void onInit() {
    if (Get.arguments != null) {
      status = Get.arguments as Status;
      name = status.name;
      editing = true;
    }
    super.onInit();
  }

  void submit() async {
    status.name = name;
    if (!editing) {
      status.id = Uuid().v4();
    }
    await Database.addStatus(status);
    final computerForm = Get.find<ComputerFormController>();
    if (computerForm != null) {
      computerForm.setNewStatus(status);
    }
    Get.back();
  }

  void nameTextChanged(String name) {
    this.name = name;
  }

  void back() {
    Get.back();
  }
}