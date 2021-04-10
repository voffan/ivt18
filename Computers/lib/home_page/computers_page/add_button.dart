import 'package:flutter/material.dart';

class AddButton extends StatelessWidget {
  final String title;
  final Function callback;

  const AddButton({Key key, @required this.title, @required this.callback}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return TextButton(
      onPressed: callback,
      style: ButtonStyle(
        backgroundColor: MaterialStateProperty.resolveWith((states) {
          if (states.contains(MaterialState.hovered)) {
            return Color(0xFF2A88F2).withOpacity(0.75);
          }
          if (states.contains(MaterialState.pressed)) {
            return Color(0xFF2A88F2).withOpacity(0.9);
          }
          return Color(0xFF2A88F2);
        }),
      ),
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
              color: Colors.white,
            ),
            Padding(
              padding: const EdgeInsets.only(left: 10.0),
              child: Text(
                title,
                style: TextStyle(
                  color: Colors.white,
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