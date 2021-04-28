// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'disk_drive.dart';

// **************************************************************************
// TypeAdapterGenerator
// **************************************************************************

class DiskDriveAdapter extends TypeAdapter<DiskDrive> {
  @override
  final int typeId = 10;

  @override
  DiskDrive read(BinaryReader reader) {
    final numOfFields = reader.readByte();
    final fields = <int, dynamic>{
      for (int i = 0; i < numOfFields; i++) reader.readByte(): reader.read(),
    };
    return DiskDrive()
      ..id = fields[0] as String
      ..model = fields[1] as String
      ..price = fields[2] as int
      ..manufacturerId = fields[3] as String
      ..statusId = fields[4] as String
      ..computerId = fields[5] as String;
  }

  @override
  void write(BinaryWriter writer, DiskDrive obj) {
    writer
      ..writeByte(6)
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
      ..write(obj.computerId);
  }

  @override
  int get hashCode => typeId.hashCode;

  @override
  bool operator ==(Object other) =>
      identical(this, other) ||
      other is DiskDriveAdapter &&
          runtimeType == other.runtimeType &&
          typeId == other.typeId;
}
