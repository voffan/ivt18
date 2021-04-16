import 'package:hive/hive.dart';

part 'power_supply.g.dart';

@HiveType(typeId: 5)
class PowerSupply {

  static String boxName = 'power_supplies';

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
  int power;

  @HiveField(6)
  String computerId;
}