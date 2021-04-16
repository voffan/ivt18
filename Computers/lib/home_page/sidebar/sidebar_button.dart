import 'package:flutter/material.dart';

class SidebarButton extends StatelessWidget {
  final String title;
  final IconData iconData;
  final Function callback;

  const SidebarButton({
    Key key, 
    @required this.title, 
    @required this.iconData,
    @required this.callback
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return TextButton(
      onPressed: callback,
      style: ButtonStyle(
        backgroundColor: MaterialStateProperty.resolveWith((states) {
          if (states.contains(MaterialState.hovered)) {
            return Colors.grey.withOpacity(0.3);
          }
          return Colors.transparent;
        }),
        shape: MaterialStateProperty.all(RoundedRectangleBorder())
      ),
      child: Container(
        padding: const EdgeInsets.symmetric(vertical: 25.0, horizontal: 38.0),
        child: Row(
          children: [
            Icon(
              iconData,
              size: 24.0,
              color: Color(0xFF707C97),
            ),
            Padding(
              padding: const EdgeInsets.only(left: 16.0),
              child: Text(
                title,
                style: TextStyle(
                  color: Color(0xFF707C97),
                  fontSize: 16.0,
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}