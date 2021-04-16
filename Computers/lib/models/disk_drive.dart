import 'package:hive/hive.dart';

part 'disk_drive.g.dart';

@HiveType(typeId: 10)
class DiskDrive {

  static String boxName = 'disk_drives';

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