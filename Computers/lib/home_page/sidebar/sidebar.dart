import 'package:computers/home_page/sidebar/sidebar_button.dart';
import 'package:flutter/material.dart';

class Sidebar extends StatelessWidget {
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
          SidebarButton(title: 'Компьютеры', iconData: Icons.computer, callback: () {},),
          SidebarButton(title: 'Периферия', iconData: Icons.mouse, callback: () {}),
          SidebarButton(title: 'Сотрудники', iconData: Icons.people, callback: () {}),
        ],
      ),
    );
  }
}