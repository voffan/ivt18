// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'computer.dart';

// **************************************************************************
// TypeAdapterGenerator
// **************************************************************************

class ComputerAdapter extends TypeAdapter<Computer> {
  @override
  final int typeId = 8;

  @override
  Computer read(BinaryReader reader) {
    final numOfFields = reader.readByte();
    final fields = <int, dynamic>{
      for (int i = 0; i < numOfFields; i++) reader.readByte(): reader.read(),
    };
    return Computer()
      ..id = fields[0] as String
      ..model = fields[1] as String
      ..price = fields[2] as int
      ..manufacturerId = fields[3] as String
      ..statusId = fields[4] as String
      ..ip = fields[5] as String
      ..itemNo = fields[6] as String
      ..employeeId = fields[7] as String
      ..diskDriveId = fields[8] as String
      ..processorId = fields[9] as String
      ..motherboardId = fields[10] as String
      ..powerSupplyIds = (fields[11] as List)?.cast<String>()
      ..memoryIds = (fields[12] as List)?.cast<String>()
      ..hardDriveIds = (fields[13] as List)?.cast<String>()
      ..graphicCardIds = (fields[14] as List)?.cast<String>();
  }

  @override
  void write(BinaryWriter writer, Computer obj) {
    writer
      ..writeByte(15)
      ..writeByte(0)
      ..write(obj.id)
      ..writeByte(1)
      ..write(obj.model)
      ..writeByte(2)
      ..write(obj.price)
      ..writeByte(3)
      ..write(obj.manufacturerId)
      ..writeByte(4)
      ..write(obj.statusId)
      ..writeByte(5)
      ..write(obj.ip)
      ..writeByte(6)
      ..write(obj.itemNo)
      ..writeByte(7)
      ..write(obj.employeeId)
      ..writeByte(8)
      ..write(obj.diskDriveId)
      ..writeByte(9)
      ..write(obj.processorId)
      ..writeByte(10)
      ..write(obj.motherboardId)
      ..writeByte(11)
      ..write(obj.powerSupplyIds)
      ..writeByte(12)
      ..write(obj.memoryIds)
      ..writeByte(13)
      ..write(obj.hardDriveIds)
      ..writeByte(14)
      ..write(obj.graphicCardIds);
  }

  @override
  int get hashCode => typeId.hashCode;

  @override
  bool operator ==(Object other) =>
      identical(this, other) ||
      other is ComputerAdapter &&
          runtimeType == other.runtimeType &&
          typeId == other.typeId;
}
