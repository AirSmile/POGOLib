// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/Inventory.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings {

  /// <summary>Holder for reflection information generated from Settings/Inventory.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class InventoryReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/Inventory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InventoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhTZXR0aW5ncy9JbnZlbnRvcnkucHJvdG8SE1BPR09Qcm90b3MuU2V0dGlu",
            "Z3MieAoJSW52ZW50b3J5EhMKC21heF9wb2tlbW9uGAEgASgFEhUKDW1heF9i",
            "YWdfaXRlbXMYAiABKAUSFAoMYmFzZV9wb2tlbW9uGAMgASgFEhYKDmJhc2Vf",
            "YmFnX2l0ZW1zGAQgASgFEhEKCWJhc2VfZWdncxgFIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Inventory), global::POGOProtos.Settings.Inventory.Parser, new[]{ "MaxPokemon", "MaxBagItems", "BasePokemon", "BaseBagItems", "BaseEggs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Inventory : pb::IMessage<Inventory> {
    private static readonly pb::MessageParser<Inventory> _parser = new pb::MessageParser<Inventory>(() => new Inventory());
    public static pb::MessageParser<Inventory> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.InventoryReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Inventory() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Inventory(Inventory other) : this() {
      maxPokemon_ = other.maxPokemon_;
      maxBagItems_ = other.maxBagItems_;
      basePokemon_ = other.basePokemon_;
      baseBagItems_ = other.baseBagItems_;
      baseEggs_ = other.baseEggs_;
    }

    public Inventory Clone() {
      return new Inventory(this);
    }

    /// <summary>Field number for the "max_pokemon" field.</summary>
    public const int MaxPokemonFieldNumber = 1;
    private int maxPokemon_;
    public int MaxPokemon {
      get { return maxPokemon_; }
      set {
        maxPokemon_ = value;
      }
    }

    /// <summary>Field number for the "max_bag_items" field.</summary>
    public const int MaxBagItemsFieldNumber = 2;
    private int maxBagItems_;
    public int MaxBagItems {
      get { return maxBagItems_; }
      set {
        maxBagItems_ = value;
      }
    }

    /// <summary>Field number for the "base_pokemon" field.</summary>
    public const int BasePokemonFieldNumber = 3;
    private int basePokemon_;
    public int BasePokemon {
      get { return basePokemon_; }
      set {
        basePokemon_ = value;
      }
    }

    /// <summary>Field number for the "base_bag_items" field.</summary>
    public const int BaseBagItemsFieldNumber = 4;
    private int baseBagItems_;
    public int BaseBagItems {
      get { return baseBagItems_; }
      set {
        baseBagItems_ = value;
      }
    }

    /// <summary>Field number for the "base_eggs" field.</summary>
    public const int BaseEggsFieldNumber = 5;
    private int baseEggs_;
    public int BaseEggs {
      get { return baseEggs_; }
      set {
        baseEggs_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Inventory);
    }

    public bool Equals(Inventory other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaxPokemon != other.MaxPokemon) return false;
      if (MaxBagItems != other.MaxBagItems) return false;
      if (BasePokemon != other.BasePokemon) return false;
      if (BaseBagItems != other.BaseBagItems) return false;
      if (BaseEggs != other.BaseEggs) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (MaxPokemon != 0) hash ^= MaxPokemon.GetHashCode();
      if (MaxBagItems != 0) hash ^= MaxBagItems.GetHashCode();
      if (BasePokemon != 0) hash ^= BasePokemon.GetHashCode();
      if (BaseBagItems != 0) hash ^= BaseBagItems.GetHashCode();
      if (BaseEggs != 0) hash ^= BaseEggs.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (MaxPokemon != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(MaxPokemon);
      }
      if (MaxBagItems != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxBagItems);
      }
      if (BasePokemon != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(BasePokemon);
      }
      if (BaseBagItems != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(BaseBagItems);
      }
      if (BaseEggs != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(BaseEggs);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (MaxPokemon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxPokemon);
      }
      if (MaxBagItems != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxBagItems);
      }
      if (BasePokemon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BasePokemon);
      }
      if (BaseBagItems != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseBagItems);
      }
      if (BaseEggs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseEggs);
      }
      return size;
    }

    public void MergeFrom(Inventory other) {
      if (other == null) {
        return;
      }
      if (other.MaxPokemon != 0) {
        MaxPokemon = other.MaxPokemon;
      }
      if (other.MaxBagItems != 0) {
        MaxBagItems = other.MaxBagItems;
      }
      if (other.BasePokemon != 0) {
        BasePokemon = other.BasePokemon;
      }
      if (other.BaseBagItems != 0) {
        BaseBagItems = other.BaseBagItems;
      }
      if (other.BaseEggs != 0) {
        BaseEggs = other.BaseEggs;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            MaxPokemon = input.ReadInt32();
            break;
          }
          case 16: {
            MaxBagItems = input.ReadInt32();
            break;
          }
          case 24: {
            BasePokemon = input.ReadInt32();
            break;
          }
          case 32: {
            BaseBagItems = input.ReadInt32();
            break;
          }
          case 40: {
            BaseEggs = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
