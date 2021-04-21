import 'package:computers/common/text_field_custom.dart';
import 'package:computers/forms/device/device_form_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class DeviceForm extends GetView<DeviceFormController> {

  final double wrapSpacing = 25.0;
  final double wrapRunSpacing = 10.0;
  final double fieldWidth = 250.0;
  final double iconSize = 20.0;

  @override
  Widget build(BuildContext context) {
    return GetBuilder<DeviceFormController>(
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
                        getTitle(),
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
                                initialValue: controller.name, 
                                onChanged: (text) => controller.nameTextChanged(text),
                              ),
                            ),
                            Container(
                              width: fieldWidth,
                              child: TextFieldCustom(
                                labelText: 'Стоимость', 
                                initialValue: controller.price?.toString(), 
                                onChanged: (text) => controller.priceTextChanged(text),
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

  String getTitle() {
    switch (controller.deviceType) {
      case DeviceType.diskDrive:
        return controller.editing ? 'Редактировать дисковод' : 'Добавить дисковод';
        break;
      case DeviceType.graphicCard:
        return controller.editing ? 'Редактировать видеокарту' : 'Добавить видеокарту';
        break;
      case DeviceType.hardDrive:
        return controller.editing ? 'Редактировать накопитель данных' : 'Добавить накопитель данных';
        break;
      case DeviceType.memory:
        return controller.editing ? 'Редактировать оперативную память' : 'Добавить оперативную память';
        break;
      case DeviceType.motherboard:
        return controller.editing ? 'Редактировать мат. плату' : 'Добавить мат. плату';
        break;
      case DeviceType.powerSupply:
        return controller.editing ? 'Редактировать источник питания' : 'Добавить источник питания';
        break;
      case DeviceType.processor:
        return controller.editing ? 'Редактировать процессор' : 'Добавить процессор';
        break;
      default:
        return '';
        break;
    }
  }
}