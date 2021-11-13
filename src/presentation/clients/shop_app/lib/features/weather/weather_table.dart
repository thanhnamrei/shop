import 'package:flutter/material.dart';
import 'package:shop_app/features/weather/weather.dart';

class WeatherTable extends StatelessWidget {
  const WeatherTable({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListView.builder(
        itemCount: 5,
        itemBuilder: (BuildContext context, int index) {
          return const Weather();
        });
  }
}
