import 'package:computers/forms/computer/computer_form_controller.dart';
import 'package:get/get.dart';

class ComputerFormBinding extends Bindings {
  @override
  void dependencies() {
    Get.put(ComputerFormController());
  }
}