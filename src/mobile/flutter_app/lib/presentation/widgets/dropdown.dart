import 'package:flutter/material.dart';
import 'package:flutter_app/presentation/themes/app_color.dart';

class Address {
  final String code;
  final String name;

  Address(this.code, this.name);
}

class Dropdown extends StatelessWidget {
  final List<Address> options;
  final String? placeholder;
  const Dropdown({super.key, required this.options, this.placeholder});

  @override
  Widget build(BuildContext context) {
    return Autocomplete<Address>(
        initialValue: const TextEditingValue(text: '2'),
        optionsBuilder: (textEditingValue) {
          return options;
        },
        displayStringForOption: (option) => option.name,
        optionsViewBuilder: (context, onSelected, options) {
          return Material(
            elevation: 4,
            child: ListView.separated(
                padding: EdgeInsets.zero,
                itemBuilder: (context, index) {
                  return ListTile(
                    title: Text(options.elementAt(index).name),
                    onTap: () {
                      onSelected(options.elementAt(index));
                    },
                  );
                },
                separatorBuilder: (context, index) => const Divider(),
                itemCount: options.length),
          );
        },
        fieldViewBuilder:
            (context, textEditingController, focusNode, onFieldSubmitted) {
          return TextField(
            controller: textEditingController,
            focusNode: focusNode,
            onEditingComplete: onFieldSubmitted,
            decoration: InputDecoration(
                hintText: placeholder,
                filled: true,
                fillColor: kGrayColor,
                suffixIcon: const Icon(
                  Icons.keyboard_arrow_down,
                  color: Colors.black,
                ),
                border: InputBorder.none),
          );
        });
  }
}
