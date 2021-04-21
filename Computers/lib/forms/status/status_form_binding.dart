import 'package:computers/forms/status/status_form_controller.dart';
import 'package:get/get.dart';

class StatusFormBinding extends Bindings {
  @override
  void dependencies() {
    Get.put(StatusFormController());
  }
}