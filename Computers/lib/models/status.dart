import 'package:hive/hive.dart';

part 'status.g.dart';

@HiveType(typeId: 7)
class Status {

  static String boxName = 'statuses';

  @HiveField(0)
  String id;
  
  @HiveField(1)
  String name;

  String toString() => name;
}