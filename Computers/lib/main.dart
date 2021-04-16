import 'dart:io';

import 'package:computers/database.dart';
import 'package:computers/forms/computer/computer_form.dart';
import 'package:computers/forms/computer/computer_form_binding.dart';
import 'package:computers/home_page/home_page.dart';
import 'package:flutter/material.dart';
import 'package:get/route_manager.dart';
import 'package:get/get.dart';

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
      ),
      darkTheme: ThemeData(
        brightness: Brightness.dark,
      ),
      themeMode: ThemeMode.light,
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
      ],
      debugShowCheckedModeBanner: false,
    );
  }
}