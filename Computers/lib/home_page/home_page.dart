import 'package:computers/home_page/computers_page/computers_page.dart';
import 'package:computers/home_page/home_page_controller.dart';
import 'package:computers/home_page/sidebar/sidebar.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class HomePage extends GetView<HomePageController> {
  @override
  Widget build(BuildContext context) {
    return GetBuilder<HomePageController>(
      builder: (controller) => Scaffold(
        body: Container(
          child: Row(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            children: [
              Sidebar(),
              Expanded(
                child: Stack(
                  children: [
                    ComputersPage(),
                    Positioned(
                      top: 25.0,
                      right: 60.0,
                      child: IconButton(
                        icon: Icon(
                          Get.isDarkMode ? Icons.wb_sunny_outlined : Icons.nights_stay_outlined
                        ), 
                        onPressed: controller.switchTheme
                      ),
                    ),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}