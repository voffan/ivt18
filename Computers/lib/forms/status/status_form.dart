import 'package:computers/common/text_field_custom.dart';
import 'package:computers/forms/status/status_form_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class StatusForm extends GetView<StatusFormController> {
  
  final double wrapSpacing = 25.0;
  final double wrapRunSpacing = 10.0;
  final double fieldWidth = 250.0;
  final double iconSize = 20.0;

  @override
  Widget build(BuildContext context) {
    return GetBuilder<StatusFormController>(
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
                        controller.editing ? 'Редактировать статус' : 'Добавить статус',
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
                                labelText: 'Название', 
                                initialValue: controller.name, 
                                onChanged: (text) => controller.nameTextChanged(text),
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