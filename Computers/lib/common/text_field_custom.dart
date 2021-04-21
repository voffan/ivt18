import 'package:flutter/material.dart';

class TextFieldCustom extends StatelessWidget {

  final String labelText;
  final String initialValue;
  final void Function(String) onChanged;

  const TextFieldCustom({
    Key key, 
    @required this.labelText,
    @required this.initialValue, 
    @required this.onChanged
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return TextFormField(
      decoration: InputDecoration(
        enabledBorder: const OutlineInputBorder(
          borderSide: const BorderSide(color: Colors.grey, width: 1.0),
        ),
        focusedBorder: OutlineInputBorder(
          borderSide: BorderSide(color: Theme.of(context).buttonColor, width: 2.0),
        ),
        border: const OutlineInputBorder(
          borderSide: const BorderSide(color: Colors.grey, width: 1.0),
        ),
        labelText: labelText,
        labelStyle: TextStyle(
          color: Theme.of(context).textTheme.bodyText1.color
        ),
      ),
      initialValue: initialValue,
      onChanged: onChanged,
    );
  }
}