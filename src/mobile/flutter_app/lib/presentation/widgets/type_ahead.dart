import 'package:flutter/material.dart';
import 'package:flutter_app/presentation/themes/app_color.dart';
import 'package:flutter_app/presentation/widgets/dropdown.dart';
import 'package:flutter_typeahead/flutter_typeahead.dart';

class TypeAhead extends StatelessWidget {
  TypeAhead({super.key});
  final TextEditingController _typeAheadController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return TypeAheadField(
      textFieldConfiguration: TextFieldConfiguration(
          // autofocus: true,
          controller: _typeAheadController,
          style: DefaultTextStyle.of(context)
              .style
              .copyWith(fontStyle: FontStyle.italic),
          decoration: const InputDecoration(
              border: InputBorder.none,
              filled: true,
              fillColor: kGrayColor,
              suffixIcon: Icon(Icons.keyboard_arrow_down))),
      suggestionsCallback: (pattern) {
        return [Address('1', '2')];
      },
      itemBuilder: (context, suggestion) {
        return ListTile(title: Text(suggestion.name));
      },
      onSuggestionSelected: (suggestion) {
        this._typeAheadController.text = suggestion.name;
      },
    );
  }
}
