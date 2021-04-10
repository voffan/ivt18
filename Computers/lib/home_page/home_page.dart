import 'package:computers/home_page/computers_page/computers_page.dart';
import 'package:computers/home_page/sidebar/sidebar.dart';
import 'package:flutter/material.dart';

class HomePage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        child: Row(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            Sidebar(),
            Expanded(
              child: ComputersPage()
            ),
          ],
        ),
      ),
    );
  }
}