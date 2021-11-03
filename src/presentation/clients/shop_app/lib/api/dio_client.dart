import 'package:dio/dio.dart';

class DioClient {
  Dio init() {
    Dio _dio = Dio();
    _dio.options.baseUrl = "";
    return _dio;
  }
}
