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
    Get.dialog(AlertDialog(
      title: Text(computer.itemNo ?? 'Компьютер без инвентарного номера'),
      // content: Text(computer.model ?? '' + ' с инвентарным номером ' + computer.itemNo ?? ''),
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