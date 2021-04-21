import 'package:computers/database.dart';
import 'package:computers/forms/computer/computer_form_controller.dart';
import 'package:computers/models/employee.dart';
import 'package:get/get.dart';
import 'package:uuid/uuid.dart';

class EmployeeFormController extends GetxController {

  Employee employee = Employee();

  String surname;
  String name;
  String patronymic;

  bool editing = false;

  @override
  void onInit() {
    if (Get.arguments != null) {
      employee = Get.arguments as Employee;
      surname = employee.surname;
      name = employee.name;
      patronymic = employee.patronymicName;
      editing = true;
    }
    super.onInit();
  }

  void submit() async {
    employee.surname = surname;
    employee.name = name;
    employee.patronymicName = patronymic;
    if (!editing) {
      employee.id = Uuid().v4();
    }
    await Database.addEmployee(employee);
    final computerForm = Get.find<ComputerFormController>();
    if (computerForm != null) {
      computerForm.setNewEmployee(employee);
    }
    Get.back();
  }

  void surnameTextChanged(String surname) {
    this.surname = surname;
  }

  void nameTextChanged(String name) {
    this.name = name;
  }

  void patronymicTextChanged(String patronymic) {
    this.patronymic = patronymic;
  }

  void back() {
    Get.back();
  }
}