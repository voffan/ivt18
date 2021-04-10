// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'hard_drive.dart';

// **************************************************************************
// TypeAdapterGenerator
// **************************************************************************

class HardDriveAdapter extends TypeAdapter<HardDrive> {
  @override
  final int typeId = 2;

  @override
  HardDrive read(BinaryReader reader) {
    final numOfFields = reader.readByte();
    final fields = <int, dynamic>{
      for (int i = 0; i < numOfFields; i++) reader.readByte(): reader.read(),
    };
    return HardDrive()
      ..id = fields[0] as String
      ..model = fields[1] as String
      ..price = fields[2] as int
      ..manufacturerId = fields[3] as String
      ..statusId = fields[4] as String
      ..capacity = fields[5] as int
      ..computerId = fields[6] as String;
  }

  @override
  void write(BinaryWriter writer, HardDrive obj) {
    writer
      ..writeByte(7)
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
      ..write(obj.capacity)
      ..writeByte(6)
      ..write(obj.computerId);
  }

  @override
  int get hashCode => typeId.hashCode;

  @override
  bool operator ==(Object other) =>
      identical(this, other) ||
      other is HardDriveAdapter &&
          runtimeType == other.runtimeType &&
          typeId == other.typeId;
}
