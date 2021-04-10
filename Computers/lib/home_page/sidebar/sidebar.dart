import 'package:computers/home_page/sidebar/sidebar_button.dart';
import 'package:flutter/material.dart';

class Sidebar extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Container(
      width: 250.0,
      decoration: BoxDecoration(
        color: Colors.white,
        boxShadow: [
          BoxShadow(
            color: Color.fromARGB(8, 86, 128, 248),
            spreadRadius: 5.0,
            blurRadius: 25.0,
            offset: Offset(14.0, 0.0),
          ),
          BoxShadow(
            color: Color.fromARGB(13, 86, 128, 248),
            spreadRadius: 5.0,
            blurRadius: 70.0,
            offset: Offset(35.0, 0.0),
          ),
        ]
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