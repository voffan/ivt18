import 'package:computers/database.dart';
import 'package:computers/models/disk_drive.dart';
import 'package:computers/models/employee.dart';
import 'package:computers/models/manufacturer.dart';
import 'package:computers/models/motherboard.dart';
import 'package:computers/models/processor.dart';
import 'package:get/get.dart';
import 'package:hive/hive.dart';

part 'computer.g.dart';

@HiveType(typeId: 8)
class Computer {

  static String boxName = 'computers';

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
  String ip;

  @HiveField(6)
  String itemNo;

  @HiveField(7)
  String employeeId;

  @HiveField(8)
  String diskDriveId;

  @HiveField(9)
  String processorId;

  @HiveField(10)
  String motherboardId;

  @HiveField(11)
  List<String> powerSupplyIds;

  @HiveField(12)
  String memoryIds;

  @HiveField(13)
  String hardDriveIds;

  @HiveField(14)
  String graphicCardIds;

  Manufacturer get manufactuer => Database.getManufacturer(manufacturerId);
  Employee get employee => Database.getEmployee(employeeId);
  DiskDrive get diskDrive => Database.getDiskDrive(diskDriveId);
  Processor get processor => Database.getProcessor(processorId);
  Motherboard get motherboard => Database.getMotherboard(motherboardId);
}