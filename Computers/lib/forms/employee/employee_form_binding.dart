import 'package:computers/forms/employee/employee_form_controller.dart';
import 'package:get/get.dart';

class EmployeeFormBinding extends Bindings {
  @override
  void dependencies() {
    Get.put(EmployeeFormController());
  }
}