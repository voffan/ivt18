// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'power_supply.dart';

// **************************************************************************
// TypeAdapterGenerator
// **************************************************************************

class PowerSupplyAdapter extends TypeAdapter<PowerSupply> {
  @override
  final int typeId = 5;

  @override
  PowerSupply read(BinaryReader reader) {
    final numOfFields = reader.readByte();
    final fields = <int, dynamic>{
      for (int i = 0; i < numOfFields; i++) reader.readByte(): reader.read(),
    };
    return PowerSupply()
      ..id = fields[0] as String
      ..model = fields[1] as String
      ..price = fields[2] as int
      ..manufacturerId = fields[3] as String
      ..statusId = fields[4] as String
      ..power = fields[5] as int
      ..computerId = fields[6] as String;
  }

  @override
  void write(BinaryWriter writer, PowerSupply obj) {
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
      ..write(obj.power)
      ..writeByte(6)
      ..write(obj.computerId);
  }

  @override
  int get hashCode => typeId.hashCode;

  @override
  bool operator ==(Object other) =>
      identical(this, other) ||
      other is PowerSupplyAdapter &&
          runtimeType == other.runtimeType &&
          typeId == other.typeId;
}
