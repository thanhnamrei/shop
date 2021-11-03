class WeatherForecast {
  late DateTime date;
  late int temperatureC;
  late int temperatureF;
  late String summary;

  WeatherForecast.fromJson(Map<String, dynamic> json) {
    date = DateTime.parse(json['date']);
    temperatureC = json['temperatureC'] as int;
    temperatureF = json['temperatureF'] as int;
    summary = json['summary'];
  }
}
