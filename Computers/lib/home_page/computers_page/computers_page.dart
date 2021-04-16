import 'package:computers/home_page/computers_page/add_button.dart';
import 'package:computers/home_page/computers_page/computers_page_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class ComputersPage extends GetView<ComputersPageController> {

  @override
  Widget build(BuildContext context) {
    return GetBuilder<ComputersPageController>(
      builder: (controller) => Container(
        decoration: BoxDecoration(
          gradient: LinearGradient(
            begin: Alignment.topLeft,
            end: Alignment.bottomRight,
            colors: [
              Color(0xFFF3F3FB),
              Color(0xFFFDFBFD),
            ],
          ),
        ),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            Padding(
              padding: const EdgeInsets.only(top: 109.0, left: 60.0, right: 60.0),
              child: Row(
                crossAxisAlignment: CrossAxisAlignment.end,
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text(
                    'Компьютеры',
                    style: TextStyle(
                      color: Color(0xFF0D1C2E),
                      fontSize: 36.0
                    ),
                  ),
                  AddButton(
                    title: 'Добавить новый компьютер', 
                    callback: controller.addComputer,
                  ),
                ],
              ),
            ),
            Padding(
              padding: const EdgeInsets.symmetric(horizontal: 60.0, vertical: 20.0),
              child: Container(
                decoration: BoxDecoration(
                  color: Colors.white,
                  borderRadius: BorderRadius.circular(6.0)
                ),
                padding: const EdgeInsets.symmetric(horizontal: 40.0, vertical: 30.0),
                child: DataTable(
                  columnSpacing: 30.0,
                  showCheckboxColumn: false,
                  columns: [
                    DataColumn(
                      label: Text('Модель'),
                      tooltip: 'Модель компьютера',
                    ),
                    DataColumn(
                      label: Text('Производитель'),
                      tooltip: 'Название производителя',
                    ),
                    DataColumn(
                      label: Text('Инвентарный номер'),
                      tooltip: 'Инвентарный номер компьютера',
                    ),
                    DataColumn(
                      label: Text('IP адрес'),
                      tooltip: 'IP адрес компьютера',
                    ),
                    DataColumn(
                      label: Text('Сотрудник'),
                      tooltip: 'Фамилия и инциал имени сотрудника',
                    ),
                  ],
                  rows: controller.computers
                    .map((computer) => DataRow(cells: [
                      computer.model == null ? DataCell.empty : DataCell(Text(computer.model)),
                      computer.manufacturerId == null ? DataCell.empty : DataCell(Text(computer.manufactuer?.toString())),
                      computer.itemNo == null ? DataCell.empty : DataCell(Text(computer.itemNo)),
                      computer.ip == null ? DataCell.empty : DataCell(Text(computer.ip)),
                      computer.employeeId == null ? DataCell.empty : DataCell(Text(computer.employee?.toString())),
                    ], onSelectChanged: (_) => controller.selectComputer(computer)))
                    .toList(),
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}