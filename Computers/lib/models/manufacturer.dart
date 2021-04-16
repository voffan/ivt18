import 'package:hive/hive.dart';

part 'manufacturer.g.dart';

@HiveType(typeId: 0)
class Manufacturer {

  static String boxName = 'manufacturers';

  @HiveField(0)
  String id;
  
  @HiveField(1)
  String name;

  Manufacturer({this.id, this.name});

  String toString() => name;
}