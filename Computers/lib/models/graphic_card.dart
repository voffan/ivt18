import 'package:hive/hive.dart';

part 'graphic_card.g.dart';

@HiveType(typeId: 1)
class GraphicCard {

  static String boxName = 'graphic_cards';

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