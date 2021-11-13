import 'package:flutter/material.dart';

class Weather extends StatelessWidget {
  const Weather({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      child: Row(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Container(
            height: 100,
            width: 100,
            child: const Icon(Icons.cloud),
          ),
          Container(
            height: 100,
            decoration: const BoxDecoration(color: Colors.amberAccent),
            child: const Text('38'),
          ),
          Container(
            height: 50,
            width: 100,
            decoration: const BoxDecoration(color: Colors.black),
          ),
        ],
      ),
    );
  }
}
