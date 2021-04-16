import 'package:hive/hive.dart';

part 'motherboard.g.dart';

@HiveType(typeId: 4)
class Motherboard {

  static String boxName = 'motherboards';

  @HiveField(0)
  String id;

  @HiveField(1)
  String model;

  @HiveField(2)
  int price;

  @HiveField(3)
  String manufacturerId;

  @HiveField(4)
  String statusId;

  @HiveField(5)
  String computerId;
}