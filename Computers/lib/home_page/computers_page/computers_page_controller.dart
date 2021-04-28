import 'package:computers/database.dart';
import 'package:computers/models/computer.dart';
import 'package:computers/models/manufacturer.dart';
import 'package:get/get.dart';
import 'package:hive/hive.dart';
import 'package:flutter/material.dart';

class ComputersPageController extends GetxController {

  List<Computer> computers = [];

  @override
  void onInit() {
    super.onInit();
  }

  @override
  void onReady() {
    updateComputers();
    super.onReady();
  }

  void updateComputers() {
    computers = Database.getComputers();
    update();
  }

  void addComputer() {
    Get.toNamed('/computer');
  }

  void editComputer(Computer computer) {
    Get.back();
    Get.toNamed('/computer', arguments: computer);
  }

  Future<void> deleteComputer(Computer computer) async {
    await Database.deleteComputer(computer);
    Get.back();
    updateComputers();
  }

  void selectComputer(Computer computer) {
    final double spacing = 10.0;
    Get.dialog(AlertDialog(
      title: Text(computer.toString()),
      content: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        mainAxisSize: MainAxisSize.min,
        children: [
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text('Инвентарный номер:'),
              SizedBox(width: spacing),
              Text(computer.itemNo ?? ''),
            ],
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text('Модель:'),
              SizedBox(width: spacing),
              Text(computer.model ?? ''),
            ],
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text('Производитель:'),
              SizedBox(width: spacing),
              Text(computer.manufactuer?.name ?? ''),
            ],
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Text('Сотрудник:'),
              SizedBox(width: spacing),
              Text(computer.employee?.toString() ?? ''),
            ],
          ),
        ],
      ),
      actions: [
        TextButton.icon(
          onPressed: () => editComputer(computer),
          style: ButtonStyle(
            foregroundColor: MaterialStateProperty.all(Colors.blue),
            padding: MaterialStateProperty.all(EdgeInsets.all(20.0))
          ),
          icon: Icon(Icons.edit), 
          label: Text('Изменить'),
        ),
        TextButton.icon(
          onPressed: () => deleteComputer(computer), 
          style: ButtonStyle(
            foregroundColor: MaterialStateProperty.all(Colors.red),
            padding: MaterialStateProperty.all(EdgeInsets.all(20.0)),
          ),
          icon: Icon(Icons.delete), 
          label: Text('Удалить'),
        ),
      ],
    ));
  }
}