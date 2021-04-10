import 'package:hive/hive.dart';

part 'hard_drive.g.dart';

@HiveType(typeId: 2)
class HardDrive {

  static String boxName = 'hard_drives';

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