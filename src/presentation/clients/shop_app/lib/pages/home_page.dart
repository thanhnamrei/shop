import 'package:flutter/material.dart';
import 'package:shop_app/api/api_provider.dart';
import 'package:shop_app/features/weather/weather_table.dart';
import 'package:shop_app/models/weather_forecast.dart';

class HomePage extends StatefulWidget {
  const HomePage({Key? key, required this.title}) : super(key: key);

  final String title;

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  ApiProvider apiProvider = ApiProvider();
  List<WeatherForecast> weathers = [];

  void _incrementCounter() async {
    var json = await apiProvider.get('WeatherForecast');
    // ignore: unnecessary_this
    this.setState(() {
      weathers =
          (json as List).map((e) => WeatherForecast.fromJson(e)).toList();
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(widget.title),
      ),
      body: WeatherTable(
        weathers: weathers,
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: _incrementCounter,
        tooltip: 'Increment',
        child: const Icon(Icons.add),
      ), // This trailing comma makes auto-formatting nicer for build methods.
    );
  }
}
