import 'package:computers/forms/manufacturer/manufacturer_form_controller.dart';
import 'package:get/get.dart';

class ManufacturerFormBinding extends Bindings {
  @override
  void dependencies() {
    Get.put(ManufacturerFormController());
  }
}