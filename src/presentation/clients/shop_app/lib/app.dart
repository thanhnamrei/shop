import 'package:flutter/material.dart';
import 'package:shop_app/features/weather/weather_page.dart';
// import 'package:shop_app/pages/home_page.dart';

class App extends StatelessWidget {
  const App({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'AZShop',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: const WeaterPage(),
    );
  }
}
