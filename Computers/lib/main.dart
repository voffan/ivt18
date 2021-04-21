import 'dart:io';

import 'package:computers/database.dart';
import 'package:computers/forms/computer/computer_form.dart';
import 'package:computers/forms/computer/computer_form_binding.dart';
import 'package:computers/forms/device/device_form.dart';
import 'package:computers/forms/device/device_form_binding.dart';
import 'package:computers/forms/status/status_form.dart';
import 'package:computers/forms/status/status_form_binding.dart';
import 'package:computers/home_page/home_page.dart';
import 'package:flutter/material.dart';
import 'package:get/route_manager.dart';
import 'package:get/get.dart';

import 'forms/employee/employee_form.dart';
import 'forms/employee/employee_form_binding.dart';
import 'forms/manufacturer/manufacturer_form.dart';
import 'forms/manufacturer/manufacturer_form_binding.dart';
import 'home_page/home_page_binding.dart';

void main() async {
  await Database.init();
  runApp(MyApp());
} 

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return GetMaterialApp(
      title: 'Computers',
      theme: ThemeData(
        brightness: Brightness.light,
        accentColorBrightness: Brightness.light,
        accentColor: Colors.blue
      ),
      darkTheme: ThemeData(
        brightness: Brightness.dark,
        accentColorBrightness: Brightness.dark,
        accentColor: Colors.blue
      ),
      themeMode: Database.getThemeMode(),
      initialRoute: '/',
      getPages: [
        GetPage(
          name: '/',
          page: () => HomePage(),
          binding: HomePageBinding()
        ),
        GetPage(
          name: '/computer',
          page: () => ComputerForm(),
          binding: ComputerFormBinding()
        ),
        GetPage(
          name: '/manufacturer',
          page: () => ManufacturerForm(),
          binding: ManufacturerFormBinding()
        ),
        GetPage(
          name: '/employee',
          page: () => EmployeeForm(),
          binding: EmployeeFormBinding()
        ),
        GetPage(
          name: '/device',
          page: () => DeviceForm(),
          binding: DeviceFormBinding()
        ),
        GetPage(
          name: '/status', 
          page: () => StatusForm(),
          binding: StatusFormBinding(),
        ),
      ],
      defaultTransition: Transition.noTransition,
      debugShowCheckedModeBanner: false,
    );
  }
}