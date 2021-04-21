import 'package:computers/database.dart';
import 'package:computers/forms/computer/computer_form_controller.dart';
import 'package:computers/models/manufacturer.dart';
import 'package:get/get.dart';
import 'package:uuid/uuid.dart';

class ManufacturerFormController extends GetxController {
  
  Manufacturer manufacturer = Manufacturer();

  String name;

  bool editing = false;

  @override
  void onInit() {
    if (Get.arguments != null) {
      manufacturer = Get.arguments as Manufacturer;
      name = manufacturer.name;
      editing = true;
    }
    super.onInit();
  }

  void submit() async {
    manufacturer.name = name;
    if (!editing) {
      manufacturer.id = Uuid().v4();
    }
    await Database.addManufacturer(manufacturer);
    final computerForm = Get.find<ComputerFormController>();
    if (computerForm != null) {
      computerForm.setNewManufacturer(manufacturer);
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