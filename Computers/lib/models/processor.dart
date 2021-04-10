import 'package:hive/hive.dart';

part 'processor.g.dart';

@HiveType(typeId: 6)
class Processor {

  static String boxName = 'processors';

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
  String frequency;

  @HiveField(6)
  int cores;

  @HiveField(7)
  int threads;

  @HiveField(8)
  String computerId;
}