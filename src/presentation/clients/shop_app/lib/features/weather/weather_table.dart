import 'package:flutter/material.dart';
import 'package:shop_app/models/weather_forecast.dart';

class WeatherTable extends StatelessWidget {
  final List<WeatherForecast> weathers;

  const WeatherTable({Key? key, required this.weathers}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListView.builder(
        itemCount: weathers.length,
        itemBuilder: (BuildContext context, int index) {
          final weather = weathers[index];
          return Center(
            child: Text(weather.summary),
          );
        });
  }
}
