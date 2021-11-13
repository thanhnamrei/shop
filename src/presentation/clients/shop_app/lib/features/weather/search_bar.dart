import 'package:flutter/material.dart';

class SearchBar extends StatelessWidget {
  const SearchBar({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return const TextField(
      decoration: InputDecoration(
        filled: true,
        fillColor: Colors.white,
        suffixIcon: Icon(
          Icons.keyboard_voice,
          color: Colors.blue,
        ),
        contentPadding: EdgeInsets.symmetric(horizontal: 8, vertical: 0),
        border: OutlineInputBorder(
            borderRadius: BorderRadius.all(Radius.circular(20.0))),
        hintText: 'Tìm kiếm hoặc nhập URL',
      ),
    );
  }
}
