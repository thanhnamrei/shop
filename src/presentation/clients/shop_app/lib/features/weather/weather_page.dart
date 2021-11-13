import 'package:flutter/material.dart';
import 'package:shop_app/features/weather/search_bar.dart';

class WeaterPage extends StatelessWidget {
  const WeaterPage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.transparent,
        elevation: 0.0,
        title: const SearchBar(),
        actions: [
          IconButton(
              onPressed: () => {},
              icon: const Icon(
                Icons.refresh,
                color: Colors.grey,
              )),
          IconButton(
              onPressed: () => {},
              icon: const Icon(
                Icons.more_horiz,
                color: Colors.grey,
              )),
        ],
      ),
      body: Container(
        color: Colors.red,
        child: Column(
          children: [
            Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: const [
                  Icon(Icons.add_circle_rounded),
                  Text('Định Quán, Đồng Nai'),
                  Icon(Icons.gps_fixed)
                ]),
            Row(
              children: [
                const Padding(
                  padding: EdgeInsets.symmetric(horizontal: 10),
                  child: Icon(
                    Icons.cloud,
                    size: 40,
                  ),
                ),
                const Text(
                  '38',
                  style: TextStyle(fontSize: 40),
                ),
                Padding(
                  padding: const EdgeInsets.symmetric(horizontal: 5),
                  child: Column(
                    children: const [Text('\u{2103}'), Text('\u{2109}')],
                  ),
                )
              ],
            )
          ],
        ),
      ),
    );
  }
}
