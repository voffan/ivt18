import 'package:flutter/material.dart';

class AddButton extends StatelessWidget {
  final String title;
  final Function callback;

  const AddButton({Key key, @required this.title, @required this.callback}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return TextButton(
      onPressed: callback,
      child: Container(
        padding: const EdgeInsets.symmetric(horizontal: 25.0, vertical: 18.0),
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(6.0),
        ),
        child: Row(
          children: [
            Icon(
              Icons.add,
              size: 24.0,
            ),
            Padding(
              padding: const EdgeInsets.only(left: 10.0),
              child: Text(
                title,
                style: TextStyle(
                  fontSize: 20.0
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}