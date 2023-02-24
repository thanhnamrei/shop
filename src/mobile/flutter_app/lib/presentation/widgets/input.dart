import 'package:flutter/material.dart';
import 'package:flutter_app/presentation/themes/app_color.dart';

class Input extends StatelessWidget {
  const Input({super.key});

  @override
  Widget build(BuildContext context) {
    return const TextField(
      decoration: InputDecoration(
          filled: true,
          fillColor: kGrayColor,
          border: InputBorder.none,
          suffixIcon: Icon(Icons.abc)),
    );
  }
}
