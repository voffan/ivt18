import 'package:computers/forms/computer/computer_form_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class ComputerForm extends GetView<ComputerFormController> {
  @override
  Widget build(BuildContext context) {
    return GetBuilder<ComputerFormController>(
      builder: (controller) => Scaffold(
        body: SingleChildScrollView(
          child: Container(
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
                        'Добавить компьютер',
                        style: TextStyle(
                          color: Color(0xFF0D1C2E),
                          fontSize: 36.0
                        ),
                      ),
                      ElevatedButton(
                        onPressed: controller.submit,
                        style: ButtonStyle(
                          padding: MaterialStateProperty.all(
                            EdgeInsets.symmetric(horizontal: 25.0, vertical: 18.0),
                          ),
                        ),
                        child: Text(
                          controller.editing ? 'Обновить' : 'Добавить',
                          style: TextStyle(
                            fontSize: 20.0,
                          ),
                        ),
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
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.stretch,
                      children: [
                        TextFormField(
                          decoration: InputDecoration(
                            border: OutlineInputBorder(),
                            labelText: 'Модель',
                          ),
                          initialValue: controller.model,
                          onChanged: (text) => controller.modelTextChanged(text),
                        ),
                        SizedBox(height: 25.0,),
                        TextFormField(
                          decoration: InputDecoration(
                            border: OutlineInputBorder(),
                            labelText: 'Инвентарный номер',
                          ),
                          initialValue: controller.itemNo,
                          onChanged: (text) => controller.itemNoTextChanged(text),
                        ),
                        SizedBox(height: 25.0,),
                        TextFormField(
                          decoration: InputDecoration(
                            border: OutlineInputBorder(),
                            labelText: 'IP адрес',
                          ),
                          initialValue: controller.ip,
                          onChanged: (text) => controller.ipTextChanged(text),
                        ),
                        SizedBox(height: 25.0,),
                        Text('Производитель'),
                        DropdownButton(
                          hint: Text('Производитель не выбран'),
                          value: controller.manufacturer,
                          onChanged: (manufacturer) => controller.selectManufacturer(manufacturer),
                          items: controller.manufacturers
                            .map((item) => DropdownMenuItem(child: Text(item.toString()), value: item,))
                            .toList(),
                        ),
                        SizedBox(height: 25.0,),
                        Text('Сотрудник'),
                        DropdownButton(
                          hint: Text('Сотрудник не выбран'),
                          value: controller.employee,
                          onChanged: (employee) => controller.selectEmployee(employee),
                          items: controller.employees
                            .map((item) => DropdownMenuItem(child: Text(item.toString()), value: item,))
                            .toList(),
                        ),
                        SizedBox(height: 25.0,),
                        Text('Дисковод'),
                        DropdownButton(
                          hint: Text('Дисковод не выбран'),
                          value: controller.diskDrive,
                          onChanged: (diskDrive) => controller.selectDiskDrive(diskDrive),
                          items: controller.diskDrives
                            .map((item) => DropdownMenuItem(child: Text(item.toString()), value: item,))
                            .toList(),
                        ),
                        SizedBox(height: 25.0,),
                        Text('Процессор'),
                        DropdownButton(
                          hint: Text('Процессор не выбран'),
                          value: controller.processor,
                          onChanged: (processor) => controller.selectProcessor(processor),
                          items: controller.processors
                            .map((item) => DropdownMenuItem(child: Text(item.toString()), value: item,))
                            .toList(),
                        ),
                        SizedBox(height: 25.0,),
                        Text('Материнская плата'),
                        DropdownButton(
                          hint: Text('Мат. плата не выбрана'),
                          value: controller.motherboard,
                          onChanged: (motherboard) => controller.selectMotherboard(motherboard),
                          items: controller.motherboards
                            .map((item) => DropdownMenuItem(child: Text(item.toString()), value: item,))
                            .toList(),
                        ),
                      ],
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}