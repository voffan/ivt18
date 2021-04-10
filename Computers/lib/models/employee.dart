import 'package:hive/hive.dart';

part 'employee.g.dart';

@HiveType(typeId: 9)
class Employee {

  static String boxName = 'employees';

  @HiveField(0)
  String id;

  @HiveField(1)
  String surname;

  @HiveField(2)
  String name;

  @HiveField(3)
  String patronymicName;

  @HiveField(4)
  String room;

  @HiveField(5)
  String computerId;

  String toString() {
    return surname + ' ' + name[0] + '.';
  }
}