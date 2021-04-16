import 'package:hive/hive.dart';

part 'memory.g.dart';

@HiveType(typeId: 3)
class Memory {

  static String boxName = 'memories';

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
  int capacity;

  @HiveField(6)
  String computerId;
}