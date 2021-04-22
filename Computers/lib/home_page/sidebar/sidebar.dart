import 'package:computers/home_page/home_page_controller.dart';
import 'package:computers/home_page/sidebar/sidebar_button.dart';
import 'package:flutter/material.dart';

class Sidebar extends StatelessWidget {

  final HomePageController controller;

  const Sidebar({Key key, @required this.controller}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      width: 250.0,
      decoration: BoxDecoration(
        color: Theme.of(context).bottomAppBarColor,
      ),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          SidebarButton(
            title: 'Компьютеры', 
            iconData: Icons.computer,
            isSelected: controller.pageIndex == 0,
            callback: () => controller.selectPage(0),
          ),
          SidebarButton(
            title: 'Периферия', 
            iconData: Icons.mouse,
            isSelected: controller.pageIndex == 1,
            callback: () => controller.selectPage(1)
          ),
          SidebarButton(
            title: 'Сотрудники', 
            iconData: Icons.people,
            isSelected: controller.pageIndex == 2,
            callback: () => controller.selectPage(2),
          ),
        ],
      ),
    );
  }
}