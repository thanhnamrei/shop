class Name {
  final String first;
  final String last;

  Name(this.first, this.last);

  @override
  String toString() => '$first $last';
}

class OfficeName extends Name {
  final String _title;

  OfficeName(this._title, String first, String last) : super(first, last);

  @override
  String toString() => '$_title ${super.toString()}';
}
