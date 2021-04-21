import 'package:computers/forms/device/device_form_controller.dart';
import 'package:get/get.dart';

class DeviceFormBinding extends Bindings {
  @override
  void dependencies() {
    Get.put(DeviceFormController());
  }
}