import 'dart:convert';

import 'package:http/http.dart' as http;

class ApiProvider {
  final String _baseUrl = "http://192.168.0.105:5001/";

  Future<dynamic> get(String url) async {
    var response = await http.get(Uri.parse(_baseUrl + url));
    if (response.statusCode == 200) {
      return jsonDecode(response.body);
    }
  }
}
