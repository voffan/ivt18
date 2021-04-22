import 'package:computers/database.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class HomePageController extends GetxController {

  int pageIndex = 0;

  void selectPage(int index) {
    pageIndex = index;
    update();
  }

  Future<void> switchTheme() async {
    Get.changeTheme(Get.isDarkMode ? ThemeData.light() : ThemeData.dark());
    await Database.setThemeMode(Get.isDarkMode ? ThemeMode.dark : ThemeMode.light);
    update();
  }
}