import 'package:computers/common/text_field_custom.dart';
import 'package:computers/forms/computer/computer_form_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class ComputerForm extends GetView<ComputerFormController> {

  final double wrapSpacing = 25.0;
  final double wrapRunSpacing = 10.0;
  final double fieldWidth = 250.0;
  final double iconSize = 20.0;

  @override
  Widget build(BuildContext context) {
    return GetBuilder<ComputerFormController>(
      builder: (controller) => Scaffold(
        body: SingleChildScrollView(
          child: Container(
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
                          fontSize: 36.0
                        ),
                      ),
                    ],
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.symmetric(horizontal: 60.0, vertical: 20.0),
                  child: Container(
                    decoration: BoxDecoration(
                      color: Theme.of(context).dialogBackgroundColor,
                      borderRadius: BorderRadius.circular(6.0)
                    ),
                    padding: const EdgeInsets.symmetric(horizontal: 40.0, vertical: 30.0),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.stretch,
                      children: [
                        Wrap(
                          spacing: wrapSpacing,
                          runSpacing: wrapRunSpacing,
                          children: [
                            Container(
                              width: fieldWidth,
                              child: TextFieldCustom(
                                labelText: 'Модель', 
                                initialValue: controller.model, 
                                onChanged: (text) => controller.modelTextChanged(text),
                              ),
                            ),
                            Container(
                              width: fieldWidth,
                              child: TextFieldCustom(
                                labelText: 'Инвентарный номер', 
                                initialValue: controller.itemNo, 
                                onChanged: (text) => controller.itemNoTextChanged(text),
                              ),
                            ),
                            Container(
                              width: fieldWidth,
                              child: TextFieldCustom(
                                labelText: 'IP адрес', 
                                initialValue: controller.ip, 
                                onChanged: (text) => controller.ipTextChanged(text),
                              ),
                            ),
                          ],
                        ),
                        SizedBox(height: 25.0,),
                        Wrap(
                          spacing: wrapSpacing,
                          runSpacing: wrapRunSpacing,
                          children: [
                            Container(
                              width: fieldWidth,
                              child: Column(
                                crossAxisAlignment: CrossAxisAlignment.stretch,
                                children: [
                                  Row(
                                    children: [
                                      Text('Сотрудник'),
                                      SizedBox(width: 5.0),
                                      IconButton(
                                        icon: Icon(
                                          Icons.add_circle_outline, 
                                          size: iconSize, 
                                          color: Theme.of(context).buttonColor,
                                        ), 
                                        onPressed: controller.createEmployee,
                                      ),
                                    ],
                                  ),
                                  DropdownButton(
                                    hint: Text('Не выбрано'),
                                    value: controller.employee,
                                    onChanged: (employee) => controller.selectEmployee(employee),
                                    items: controller.employees
                                      .map((item) => DropdownMenuItem(child: Text(item.toString()), value: item,))
                                      .toList(),
                                  ),
                                ],
                              ),
                            ),
                            Container(
                              width: fieldWidth,
                              child: Column(
                                crossAxisAlignment: CrossAxisAlignment.stretch,
                                children: [
                                  Row(
                                    children: [
                                      Text('Материнская плата'),
                                      SizedBox(width: 5.0),
                                      IconButton(
                                        icon: Icon(
                                          Icons.add_circle_outline, 
                                          size: iconSize, 
                                          color: Theme.of(context).buttonColor,
                                        ), 
                                        onPressed: controller.createMotherboard,
                                      ),
                                    ],
                                  ),
                                  DropdownButton(
                                    hint: Text('Не выбрано'),
                                    value: controller.motherboard,
                                    onChanged: (motherboard) => controller.selectMotherboard(motherboard),
                                    items: controller.motherboards
                                      .map((item) => DropdownMenuItem(child: Text(item.toString()), value: item,))
                                      .toList(),
                                  ),
                                ],
                              ),
                            ),
                            Container(
                              width: fieldWidth,
                              child: Column(
                                crossAxisAlignment: CrossAxisAlignment.stretch,
                                children: [
                                  Row(
                                    children: [
                                      Text('Процессор'),
                                      SizedBox(width: 5.0),
                                      IconButton(
                                        icon: Icon(
                                          Icons.add_circle_outline, 
                                          size: iconSize, 
                                          color: Theme.of(context).buttonColor,
                                        ), 
                                        onPressed: controller.createProcessor,
                                      ),
                                    ],
                                  ),
                                  DropdownButton(
                                    hint: Text('Не выбрано'),
                                    value: controller.processor,
                                    onChanged: (processor) => controller.selectProcessor(processor),
                                    items: controller.processors
                                      .map((item) => DropdownMenuItem(child: Text(item.toString()), value: item,))
                                      .toList(),
                                  ),
                                ],
                              ),
                            ),
                            Container(
                              width: fieldWidth,
                              child: Column(
                                crossAxisAlignment: CrossAxisAlignment.stretch,
                                children: [
                                  Row(
                                    children: [
                                      Text('Дисковод'),
                                      SizedBox(width: 5.0),
                                      IconButton(
                                        icon: Icon(
                                          Icons.add_circle_outline, 
                                          size: iconSize, 
                                          color: Theme.of(context).buttonColor,
                                        ), 
                                        onPressed: controller.createDiskDrive,
                                      ),
                                    ],
                                  ),
                                  DropdownButton(
                                    hint: Text('Не выбрано'),
                                    value: controller.diskDrive,
                                    onChanged: (diskDrive) => controller.selectDiskDrive(diskDrive),
                                    items: controller.diskDrives
                                      .map((item) => DropdownMenuItem(child: Text(item.toString()), value: item,))
                                      .toList(),
                                  ),
                                ],
                              ),
                            ),
                            Container(
                              width: fieldWidth,
                              child: Column(
                                crossAxisAlignment: CrossAxisAlignment.stretch,
                                children: [
                                  Row(
                                    children: [
                                      Text('Производитель'),
                                      SizedBox(width: 5.0),
                                      IconButton(
                                        icon: Icon(
                                          Icons.add_circle_outline, 
                                          size: iconSize, 
                                          color: Theme.of(context).buttonColor,
                                        ), 
                                        onPressed: controller.createManufacturer,
                                      ),
                                    ],
                                  ),
                                  DropdownButton(
                                    hint: Text('Не выбрано'),
                                    value: controller.manufacturer,
                                    onChanged: (manufacturer) => controller.selectManufacturer(manufacturer),
                                    items: controller.manufacturers
                                      .map((item) => DropdownMenuItem(child: Text(item.toString()), value: item,))
                                      .toList(),
                                  ),
                                ],
                              ),
                            ),
                            Container(
                              width: fieldWidth,
                              child: Column(
                                crossAxisAlignment: CrossAxisAlignment.stretch,
                                children: [
                                  Row(
                                    children: [
                                      Text('Статус'),
                                      SizedBox(width: 5.0),
                                      IconButton(
                                        icon: Icon(
                                          Icons.add_circle_outline, 
                                          size: iconSize, 
                                          color: Theme.of(context).buttonColor,
                                        ), 
                                        onPressed: controller.createStatus,
                                      ),
                                    ],
                                  ),
                                  DropdownButton(
                                    hint: Text('Не выбрано'),
                                    value: controller.status,
                                    onChanged: (status) => controller.selectStatus(status),
                                    items: controller.statuses
                                      .map((item) => DropdownMenuItem(child: Text(item.toString()), value: item,))
                                      .toList(),
                                  ),
                                ],
                              ),
                            ),
                          ],
                        ),
                      ],
                    ),
                  ),
                ),
                SizedBox(height: 25.0,),
                Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    TextButton(
                      onPressed: controller.back, 
                      child: Padding(
                        padding: const EdgeInsets.symmetric(horizontal: 25.0, vertical: 18.0),
                        child: Text(
                          'Отмена',
                          style: TextStyle(
                            fontSize: 20.0,
                          ),
                        ),
                      ),
                    ),
                    SizedBox(width: 20.0),
                    TextButton(
                      onPressed: controller.submit, 
                      child: Padding(
                        padding: const EdgeInsets.symmetric(horizontal: 25.0, vertical: 18.0),
                        child: Text(
                          controller.editing ? 'Обновить' : 'Добавить',
                          style: TextStyle(
                            fontSize: 20.0,
                          ),
                        ),
                      ),
                    ),
                  ],
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}