﻿namespace AAEmu.Game.Core.Packets.G2C
{
    public static class SCOffsets
    {
        // All opcodes here are updated for version client_18_r243378
        public const ushort X2EnterWorldResponsePacket = 0x000;
        public const ushort SCReconnectAuthPacket = 0x0e7;
        public const ushort SCPrepareLeaveWorldPacket = 0x157;
        public const ushort SCLeaveWorldGrantedPacket = 0x222;
        public const ushort SCLeaveWorldCanceledPacket = 0x1d6;
        public const ushort SCWorldQueuePacket = 0x079;
        public const ushort SCInitialConfigPacket = 0x241;
        public const ushort SCTrionConfigPacket = 0x20f;
        public const ushort SCFactionListPacket = 0x131;
        public const ushort SCFactionRelationListPacket = 0x10b;
        public const ushort SCExpeditionRolePolicyListPacket = 0x195;
        public const ushort SCExpeditionRolePolicyChangedPacket = 0x11e;
        public const ushort SCExpeditionRoleChangedPacket = 0x02a;
        public const ushort SCExpeditionOwnerChangedPacket = 0x008;
        public const ushort SCExpeditionShowRenameUIPacket = 0x0ef;
        public const ushort SCUnknownPacket_0x0d4 = 0x0d4;
        public const ushort SCFactionRenamedPacket = 0x239;
        public const ushort SCFactionRetryRenamePacket = 0x03e;
        public const ushort SCFactionCreatedPacket = 0x19a;
        public const ushort SCExpeditionSponsorChangedPacket = 0x114;
        public const ushort SCExpeditionDismissedPacket = 0x261;
        public const ushort SCUnknownPacket_0x03d = 0x03d;
        public const ushort SCFactionSetRelationStatePacket = 0x18c;
        public const ushort SCExpeditionInvitationPacket = 0x24b;
        public const ushort SCUnitFactionChangedPacket = 0x233;
        public const ushort SCUnitExpeditionChangedPacket = 0x226;
        public const ushort SCExpeditionMemberListPacket = 0x112;
        public const ushort SCExpeditionMemberStatusChangedPacket = 0x143;
        public const ushort SCFactionOwnerChangedPacket = 0x028;
        public const ushort SCFamilyInvitationPacket = 0x22a;
        public const ushort SCFamilyCreatedPacket = 0x061;
        public const ushort SCFamilyRemovedPacket = 0x1e2;
        public const ushort SCFamilyDescPacket = 0x1c6;
        public const ushort SCFamilyMemberAddedPacket = 0x105;
        public const ushort SCFamilyMemberRemovedPacket = 0x04a;
        public const ushort SCFamilyOwnerChangedPacket = 0x19d;
        public const ushort SCFamilyTitleChangedPacket = 0x0d9;
        public const ushort SCFamilyMemberNameChangedPacket = 0x08a;
        public const ushort SCFamilyTitlePacket = 0x148;
        public const ushort SCFamilyMemberOnlinePacket = 0x1d1;
        public const ushort SCDeleteCharacterResponsePacket = 0x036;
        public const ushort SCCharacterDeletedPacket = 0x11d;
        public const ushort SCCancelCharacterDeleteResponsePacket = 0x123;
        public const ushort SCCharacterCreationFailedPacket = 0x158;
        public const ushort SCRaceCongestionPacket = 0x20e;
        public const ushort SCCharacterInvenInitPacket = 0x064;
        public const ushort SCCharacterInvenContentsPacket = 0x00c;
        public const ushort SCInvenExpandedPacket = 0x0b6;
        public const ushort SCNotifyResurrectionPacket = 0x19f;
        public const ushort SCCharacterResurrectedPacket = 0x119;
        public const ushort SCForceAttackSetPacket = 0x198;
        public const ushort SCBmPointPacket = 0x1cc;
        public const ushort SCAddActionPointPacket = 0x002;
        public const ushort SCLpManagedPacket = 0x059;
        public const ushort SCExpertLimitModifiedPacket = 0x20c;
        public const ushort SCExpertExpandedPacket = 0x0a3;
        public const ushort SCAccountInfoPacket = 0x185;
        public const ushort SCDumpCombatInfoPacket = 0x019;
        public const ushort SCUccCheckedPacket = 0x0f7;
        public const ushort SCUnknownPacket_0x009 = 0x009;
        public const ushort SCSlaveRemovedPacket = 0x00e;
        public const ushort SCSlaveDespawnPacket = 0x054;
        public const ushort SCSlaveBoundPacket = 0x172;
        public const ushort SCMySlavePacket = 0x0a0;
        public const ushort SCEscapeSlavePacket = 0x0db;
        //public const ushort SCMateEquipmentExpiredPacket = 0x1e4;
        public const ushort SCUnknownPacket_0x055 = 0x055;
        public const ushort SCUnitsRemovedPacket = 0x17c;
        public const ushort SCUnitOfflinePacket = 0x1c7;
        public const ushort SCSkillControllerStatePacket = 0x0e0;
        public const ushort SCActiveWeaponChangedPacket = 0x1c9;
        public const ushort SCUnitNameChangedPacket = 0x08e;
        public const ushort SCUnitDeathPacket = 0x13b;
        public const ushort SCTeleportUnitPacket = 0x0fd;
        public const ushort SCBlinkUnitPacket = 0x015;
        public const ushort SCUnitAttachedPacket = 0x07e;
        public const ushort SCUnitDetachedPacket = 0x09d;
        public const ushort SCUnitInvisiblePacket = 0x085;
        public const ushort SCUnitFlyingStateChangedPacket = 0x237;
        public const ushort SCTargetChangedPacket = 0x254;
        public const ushort SCUnitEquipmentIdsPacket = 0x1f0;
        public const ushort SCErrorMessagePacket = 0x1f1;
        public const ushort SCSyncItemLifespanPacket = 0x218;
        public const ushort SCSpecialtyRatioPacket = 0x22f;
        public const ushort SCSpecialtyGoodsPacket = 0x23d;
        public const ushort SCSpecialtyRecordsPacket = 0x08f;
        public const ushort SCItemSocketingLunagemResultPacket = 0x0bf;
        public const ushort SCItemSocketingLunastoneResultPacket = 0x1ec;
        public const ushort SCSkillStartedPacket = 0x169;
        public const ushort SCSkillFiredPacket = 0x07d;
        public const ushort SCSkillEndedPacket = 0x118;
        public const ushort SCSkillStoppedPacket = 0x192;
        public const ushort SCCastingStoppedPacket = 0x21f;
        public const ushort SCCastingDelayedPacket = 0x06d;
        public const ushort SCUnitDamagedPacket = 0x05b;
        public const ushort SCUnitHealedPacket = 0x05d;
        public const ushort SCUnknownPacket_0x070 = 0x070;
        public const ushort SCBuffCreatedPacket = 0x1ef;
        public const ushort SCBuffRemovedPacket = 0x10d;
        public const ushort SCBuffUpdatedPacket = 0x039;
        public const ushort SCUnitPointsPacket = 0x07a;
        public const ushort SCCombatEngagedPacket = 0x1d4;
        public const ushort SCCombatClearedPacket = 0x21e;
        public const ushort SCCombatFirstHitPacket = 0x180;
        public const ushort SCDumpCombatStatPacket = 0x129;
        public const ushort SCDuelChallengedPacket = 0x12c;
        public const ushort SCDuelStartCountdownPacket = 0x235;
        public const ushort SCDuelStartedPacket = 0x0d7;
        public const ushort SCDuelEndedPacket = 0x134;
        public const ushort SCDuelStatePacket = 0x165;
        public const ushort SCHouseBuildProgressPacket = 0x096;
        public const ushort SCHousePermissionChangedPacket = 0x145;
        public const ushort SCHouseDemolishedPacket = 0x0b1;
        public const ushort SCMyHouseRemovedPacket = 0x12f;
        public const ushort SCHouseFarmPacket = 0x104;
        public const ushort SCHousingRecoverTogglePacket = 0x0e6;
        public const ushort SCHouseResetForSalePacket = 0x257;
        public const ushort SCHouseSoldPacket = 0x0f9;
        public const ushort SCHouseOwnerNameChangedPacket = 0x16c;
        public const ushort SCUnknownPacket_0x161 = 0x161;
        public const ushort SCJoinedChatChannelPacket = 0x163;
        public const ushort SCLeavedChatChannelPacket = 0x1f5;
        public const ushort SCChatMessagePacket = 0x1ea;
        public const ushort SCChatLocalizedMessagePacket = 0x09b;
        public const ushort SCNpcChatMessagePacket = 0x050;
        public const ushort SCUnknownPacket_0x014 = 0x014;
        public const ushort SCNoticeMessagePacket = 0x256;
        public const ushort SCChatFailedPacket = 0x0b2;
        public const ushort SCAskToJoinTeamPacket = 0x156;
        public const ushort SCAskToJoinTeamAreaPacket = 0x091;
        public const ushort SCRejectedTeamPacket = 0x117;
        public const ushort SCLeavedTeamPacket = 0x1e8;
        public const ushort SCTeamDismissedPacket = 0x080;
        public const ushort SCTeamMemberJoinedPacket = 0x194;
        public const ushort SCTeamMemberLeavedPacket = 0x102;
        public const ushort SCTeamOwnerChangedPacket = 0x202;
        public const ushort SCTeamMemberRoleChangedPacket = 0x1db;
        public const ushort SCTeamBecameRaidTeamPacket = 0x149;
        public const ushort SCTeamMemberMovedPacket = 0x214;
        public const ushort SCRefreshTeamMemberPacket = 0x0ae;
        public const ushort SCTeamRemoteMembersExPacket = 0x128;
        public const ushort SCTeamAreaInvitedPacket = 0x027;
        public const ushort SCOverHeadMarkerSetPacket = 0x13f;
        public const ushort SCTeamAckRiskyActionPacket = 0x048;
        public const ushort SCUnknownPacket_0x12b = 0x12b;
        public const ushort SCUnknownPacket_0x0f3 = 0x0f3;
        public const ushort SCUnknownPacket_0x21c = 0x21c;
        public const ushort SCSiegeDeclaredPacket = 0x1a1;
        public const ushort SCSiegeReinforcePacket = 0x0f4;
        public const ushort SCSiegeMemberPacket = 0x142;
        public const ushort SCSiegeAlertPacket = 0x215;
        public const ushort SCConflictZoneStatePacket = 0x262;
        public const ushort SCConflictZoneHonorPointSumPacket = 0x067;
        public const ushort SCTimeOfDayPacket = 0x1fc;
        public const ushort SCUnknownPacket_0x23c = 0x23c;
        public const ushort SCDetailedTimeOfDayPacket = 0x007;
        public const ushort SCNpcInteractionSkillListPacket = 0x0ed;
        public const ushort SCNpcInteractionEndedByZonePacket = 0x22e;
        public const ushort SCWorldInteractionSkillListPacket = 0x043;
        public const ushort SCWorldInteractionCanceledPacket = 0x072;
        public const ushort SCNpcInteractionStatusChangedPacket = 0x1b1;
        public const ushort SCVegetationCutdowningPacket = 0x255;
        public const ushort SCNpcFriendshipListPacket = 0x1a8;
        public const ushort SCNpcFriendshipChangedPacket = 0x0d0;
        public const ushort SCCompletedQuestsPacket = 0x07b;
        public const ushort SCCraftItemUnlockPacket = 0x168;
        public const ushort SCLootableStatePacket = 0x1ce;
        public const ushort SCUnitLootingStatePacket = 0x204;
        public const ushort SCLootItemTookPacket = 0x081;
        public const ushort SCLootItemFailedPacket = 0x110;
        public const ushort SCLootDiceSummaryPacket = 0x25d;
        public const ushort SCExpChangedPacket = 0x1a0;
        public const ushort SCAbilityExpChangedPacket = 0x1ca;
        public const ushort SCRecoverableExpPacket = 0x1c4;
        public const ushort SCMileageChangedPacket = 0x120;
        public const ushort SCLevelChangedPacket = 0x1bb;
        public const ushort SCUnitModelPostureChangedPacket = 0x18a;
        public const ushort SCSkillLearnedPacket = 0x024;
        public const ushort SCBuffLearnedPacket = 0x0c9;
        public const ushort SCSkillsResetPacket = 0x125;
        public const ushort SCAbilitySwappedPacket = 0x0d3;
        public const ushort SCErrorMsgPacket = 0x21a;
        public const ushort SCDoodadRemovedPacket = 0x253;
        public const ushort SCDoodadChangedPacket = 0x121;
        public const ushort SCDoodadPhaseChangedPacket = 0x15c;
        public const ushort SCDoodadPuzzleScenePacket = 0x08c;
        public const ushort SCDoodadQuestAcceptPacket = 0x1e5;
        public const ushort SCDoodadsRemovedPacket = 0x0e1;
        public const ushort SCDoodadOriginatorPacket = 0x0c1;
        public const ushort SCMineAmountPacket = 0x03c;
        public const ushort SCMailFailedPacket = 0x217;
        public const ushort SCCountUnreadMailPacket = 0x1a4;
        public const ushort SCMailSentPacket = 0x187;
        public const ushort SCMailListPacket = 0x141;
        public const ushort SCMailListEndPacket = 0x1eb;
        public const ushort SCMailReceiverOpenedPacket = 0x1a6;
        public const ushort SCAttachmentTakenPacket = 0x115;
        public const ushort SCMailDeletedPacket = 0x0af;
        public const ushort SCSpamReportedPacket = 0x1e9;
        public const ushort SCMailReturnedPacket = 0x082;
        public const ushort SCMailStatusUpdatedPacket = 0x1fe;
        public const ushort SCMailRemovedPacket = 0x060;
        public const ushort SCMateSpawnedPacket = 0x087;
        public const ushort SCMateEquipmentExpiredPacket = 0x1d7;
        public const ushort SCEmotionExpressedPacket = 0x17a;
        public const ushort SCActionSlotsPacket = 0x0dd;
        public const ushort SCAuctionBidPacket = 0x095;
        public const ushort SCUnknownPacket_0x193 = 0x193;
        public const ushort SCUnitTrackedPacket = 0x010;
        public const ushort SCBombUpdatedPacket = 0x06e;
        public const ushort SCCombatTextPacket = 0x135;
        public const ushort SCSkillCooldownResetPacket = 0x0c0;
        public const ushort SCPlotEndedPacket = 0x051;
        public const ushort SCPlotProcessingTimePacket = 0x1ed;
        public const ushort SCPlotCastingStoppedPacket = 0x24c;
        public const ushort SCPlotChannelingStoppedPacket = 0x0f2;
        public const ushort SCEnvDamagePacket = 0x001;
        public const ushort SCOnOffSnowPacket = 0x0a4;
        public const ushort SCDiceValuePacket = 0x1c1;
        public const ushort SCHungPacket = 0x113;
        public const ushort SCUnhungPacket = 0x0a7;
        public const ushort SCBondDoodadPacket = 0x162;
        public const ushort SCUnbondDoodadPacket = 0x252;
        public const ushort SCPlaySequencePacket = 0x0c7;
        public const ushort SCGimmicksRemovedPacket = 0x209;
        public const ushort SCGimmickJointsBrokenPacket = 0x20d;
        public const ushort SCGimmickResetJointsPacket = 0x1d2;
        public const ushort SCGimmickGraspedPacket = 0x02f;
        public const ushort SCWorldRayCastingResultPacket = 0x07c;
        public const ushort SCimpactVelPacket = 0x030;
        public const ushort SCWorldAimPointPacket = 0x210;
        public const ushort SCQuestContextFailedPacket = 0x175;
        public const ushort SCQuestUnitReqFailedPacket = 0x201;
        public const ushort SCCSQuestAcceptConditionalPacket = 0x13d;
        public const ushort SCQuestContextCompletedPacket = 0x0e5;
        public const ushort SCQuestContextResetPacket = 0x186;
        public const ushort SCDoodadCompleteQuestPacket = 0x10e;
        public const ushort SCQuestRewardedByMailPacket = 0x0a5;
        public const ushort SCUnknownPacket_0x0ac = 0x0ac;
        public const ushort SCQuestMailSentPacket = 0x13e;
        public const ushort SCScheduleItemSentPacket = 0x1d9;
        public const ushort SCGmCommandPacket = 0x04b;
        public const ushort SCGmDumpInventoryPacket = 0x0d8;
        public const ushort SCGmDumpCompletedQuestsPacket = 0x004;
        public const ushort SCUnknownPacket_0x11b = 0x11b;
        public const ushort SCUnknownPacket_0x1ff = 0x1ff;
        public const ushort SCUnknownPacket_0x047 = 0x047;
        public const ushort SCUnknownPacket_0x122 = 0x122;
        public const ushort SCUnknownPacket_0x12d = 0x12d;
        public const ushort SCUnknownPacket_0x23b = 0x23b;
        public const ushort SCUnknownPacket_0x18d = 0x18d;
        public const ushort SCUnknownPacket_0x133 = 0x133;
        public const ushort SCUnknownPacket_0x056 = 0x056;
        public const ushort SCUnknownPacket_0x216 = 0x216;
        public const ushort SCUnknownPacket_0x03b = 0x03b;
        public const ushort SCUnknownPacket_0x0b8 = 0x0b8;
        public const ushort SCUnknownPacket_0x231 = 0x231;
        public const ushort SCUnknownPacket_0x176 = 0x176;
        public const ushort SCUnknownPacket_0x23f = 0x23f;
        public const ushort SCKickedPacket = 0x1a3;
        public const ushort SCAccountWarnedPacket = 0x1a2;
        public const ushort SCWorldMessagePacket = 0x0f8;
        public const ushort SCAboxTeleportPacket = 0x10a;
        public const ushort SCPortalDeletedPacket = 0x0f5;
        public const ushort SCUnitPortalUsedPacket = 0x0bd;
        public const ushort SCSoundAreaEventPacket = 0x01b;
        public const ushort SCAreaChatBubblePacket = 0x1f3;
        public const ushort SCChatBubblePacket = 0x00b;
        public const ushort SCAreaTeamMessagePacket = 0x132;
        public const ushort SCDoodadSoundPacket = 0x1f8;
        public const ushort SCDoodadPhaseMsgPacket = 0x177;
        public const ushort SCCooldownsPacket = 0x021;
        public const ushort SCDoodadUccPacket = 0x160;
        public const ushort SCUccCharacterNameLoadedPacket = 0x116;
        public const ushort SCNaviTeleportPacket = 0x188;
        public const ushort SCTradeStartedPacket = 0x11a;
        public const ushort SCCanStartTradePacket = 0x0ca;
        public const ushort SCCannotStartTradePacket = 0x152;
        public const ushort SCTradeCanceledPacket = 0x1b4;
        public const ushort SCTradeItemPutupPacket = 0x0df;
        public const ushort SCTradeItemTookdownPacket = 0x033;
        public const ushort SCTradeOkUpdatePacket = 0x0cc;
        public const ushort SCTradeLockUpdatePacket = 0x05a;
        public const ushort SCTowerDefListPacket = 0x069;
        public const ushort SCTowerDefStartPacket = 0x18e;
        public const ushort SCTowerDefEndPacket = 0x196;
        public const ushort SCTowerDefWaveStartPacket = 0x171;
        public const ushort SCCrimeChangedPacket = 0x0fc;
        public const ushort SCCriminalArrestedPacket = 0x1d8;
        public const ushort SCAskImprisonOrTrialPacket = 0x166;
        public const ushort SCInviteJuryPacket = 0x1cd;
        public const ushort SCSummonJuryPacket = 0x0dc;
        public const ushort SCJuryBeSeatedPacket = 0x0da;
        public const ushort SCSummonDefendantPacket = 0x101;
        public const ushort SCCrimeDataPacket = 0x0fb;
        public const ushort SCCrimeRecordsPacket = 0x15f;
        public const ushort SCTrialInfoPacket = 0x13c;
        public const ushort SCChangeTrialStatePacket = 0x084;
        public const ushort SCChangeJuryOKCountPacket = 0x0a6;
        public const ushort SCChangeJuryVerdictCountPacket = 0x029;
        public const ushort SCTrialWaitStatusPacket = 0x013;
        public const ushort SCJuryWaitStatusPacket = 0x263;
        public const ushort SCRulingStatusPacket = 0x1f7;
        public const ushort SCRulingClosedPacket = 0x1df;
        public const ushort SCTrialAudienceJoinedPacket = 0x220;
        public const ushort SCTrialAudienceLeftPacket = 0x111;
        public const ushort SCJuryWaitingNumberPacket = 0x16d;
        public const ushort SCTrialCancledPacket = 0x147;
        public const ushort SCBotSuspectReportedPacket = 0x005;
        public const ushort SCBotSuspectArrestedPacket = 0x040;
        public const ushort SCSuspectGoingBotTrialPacket = 0x0a2;
        public const ushort SCUnderWaterPacket = 0x016;
        public const ushort SCCharacterGamePointsPacket = 0x240;
        public const ushort SCJuryPointChangedPacket = 0x086;
        public const ushort SCAppliedToInstantGamePacket = 0x0a8;
        public const ushort SCCancelInstantGamePacket = 0x0b0;
        public const ushort SCInstantGameStatePacket = 0x01a;
        public const ushort SCInviteToInstantGamePacket = 0x089;
        public const ushort SCInstantGameInviteTimeoutPacket = 0x0d2;
        public const ushort SCInstantGameJoinedPacket = 0x0cd;
        public const ushort SCInstantGameStartPacket = 0x088;
        public const ushort SCInstantGameEndPacket = 0x182;
        public const ushort SCInstantGameAddPointPacket = 0x1e7;
        public const ushort SCInstantGameKillPacket = 0x20b;
        public const ushort SCInstantGameKillstreakPacket = 0x006;
        public const ushort SCInstantGamePacket = 0x022;
        public const ushort SCProcessingInstancePacket = 0x0aa;
        public const ushort SCUnknownPacket_0x173 = 0x173;
        public const ushort SCUnknownPacket_0x1f9 = 0x1f9;
        public const ushort SCUnknownPacket_0x083 = 0x083;
        public const ushort SCUnknownPacket_0x15d = 0x15d;
        public const ushort SCAppellationsPacket = 0x199;
        public const ushort SCAppellationGainedPacket = 0x094;
        public const ushort SCAppellationChangedPacket = 0x208;
        public const ushort SCTutorialSavedPacket = 0x099;
        public const ushort SCEmblemUploadedPacket = 0x1b6;
        public const ushort SCEmblemDownloadedPacket = 0x228;
        public const ushort SCDoodadUccStringPacket = 0x1b8;
        public const ushort SCSlaveStatePacket = 0x073;
        public const ushort SCMateStatePacket = 0x151;
        public const ushort SCFriendsPacket = 0x189;
        public const ushort SCSearchListPacket = 0x0b9;
        public const ushort SCAddFriendPacket = 0x0b5;
        public const ushort SCDeleteFriendPacket = 0x0c8;
        public const ushort SCFriendStatusChangedPacket = 0x031;
        public const ushort SCBlockedUsersPacket = 0x17b;
        public const ushort SCAddBlockedUserPacket = 0x1f6;
        public const ushort SCDeleteBlockedUserPacket = 0x0ec;
        public const ushort SCCharBriefPacket = 0x0ee;
        public const ushort SCPlaytimePacket = 0x22b;
        public const ushort SCCharacterRenamedPacket = 0x140;
        public const ushort SCUnknownPacket_0x1c3 = 0x1c3;
        public const ushort SCItemUccDataChangedPacket = 0x1e6;
        public const ushort SCShowQuestAreaPacket = 0x0f1;
        public const ushort SCShowCommonFarmPacket = 0x0f0;
        public const ushort SCTelescopeToggledPacket = 0x12e;
        public const ushort SCTransferTelescopeToggledPacket = 0x0fa;
        public const ushort SCSchoolOfFishFinderToggledPacket = 0x026;
        public const ushort SCUnknownPacket_0x1b7 = 0x1b7;
        public const ushort SCUnknownPacket_0x0e3 = 0x0e3;
        public const ushort SCDominionOwnerChangedPacket = 0x265;
        public const ushort SCDominionTaxRatePacket = 0x138;
        public const ushort SCNationalTaxRatePacket = 0x03a;
        public const ushort SCNationalMonumentChangedPacket = 0x248;
        public const ushort SCDominionTaxBalancedPacket = 0x04d;
        public const ushort SCDominionStartPacket = 0x1bf;
        public const ushort SCDominionEndPacket = 0x25f;
        public const ushort SCFactionIndependencePacket = 0x1ba;
        public const ushort SCFactionImmigrateInvitePacket = 0x1b2;
        public const ushort SCFactionImmigrateInviteResultPacket = 0x191;
        public const ushort SCFactionImmigrateToOriginResultPacket = 0x066;
        public const ushort SCFactionKickToOriginResultPacket = 0x183;
        public const ushort SCFactionDeclareHostileResultPacket = 0x10c;
        public const ushort SCFactionRelationExpiredPacket = 0x25e;
        public const ushort SCUnknownPacket_0x153 = 0x153;
        public const ushort SCShowDemoModeUiPacket = 0x00a;
        public const ushort SCDemoCharResetItemPacket = 0x197;
        public const ushort SCDemoCharResetLocPacket = 0x207;
        public const ushort SCDemoResetActionSlotPacket = 0x234;
        public const ushort SCSetBreathPacket = 0x1ee;
        public const ushort SCAggroTargetChangedPacket = 0x258;
        public const ushort SCHSRequestPacket = 0x049;
        public const ushort SCHackGuardRetAddrsRequestPacket = 0x098;
        public const ushort SCUnknownPacket_0x0fe = 0x0fe;
        public const ushort SCDoodadReqBattleFieldPacket = 0x17e;
        public const ushort SCCraftFailedPacket = 0x017;
        public const ushort SCUnitLocationPacket = 0x14d;
        public const ushort SCRestrictInfoPacket = 0x14f;
        public const ushort SCIsUnitInFarmPacket = 0x063;
        public const ushort SCResponseUIDataPacket = 0x05c;
        public const ushort SCUnitVisualOptionsPacket = 0x057;
        public const ushort SCUnknownPacket_0x1b9 = 0x1b9;
        public const ushort SCNotifyUIMessagePacket = 0x04e;
        public const ushort SCRefreshInCharacterListPacket = 0x227;
        public const ushort SCResultRestrictCheckPacket = 0x06c;
        public const ushort SCICSMenuListPacket = 0x1fd;
        public const ushort SCICSGoodListPacket = 0x020;
        public const ushort SCICSGoodDetailPacket = 0x06b;
        public const ushort SCICSCheckTimePacket = 0x144;
        public const ushort SCICSBuyResultPacket = 0x16f;
        public const ushort SCICSSyncGoodPacket = 0x13a;
        public const ushort SCICSCashPointPacket = 0x1c0;
        public const ushort SCBountyListPacket = 0x0eb;
        public const ushort SCInvitationCanceledPacket = 0x103;
        public const ushort SCPlaySoundPacket = 0x0c4;
        public const ushort SCSendUserMusicPacket = 0x075;
        public const ushort SCUserNoteLoadedPacket = 0x003;
        public const ushort SCPauseUserMusicPacket = 0x0cb;
        public const ushort SCGetSlotCountPacket = 0x09c;
        public const ushort SCSecondPassSettedPacket = 0x0c5;
        public const ushort SCSecondPassKeyTablesPacket = 0x14e;
        public const ushort SCSecondPassCreatedPacket = 0x02e;
        public const ushort SCSecondPassChangedPacket = 0x25b;
        public const ushort SCSecondPassCheckedPacket = 0x018;
        public const ushort SCSecondPassClearedPacket = 0x0cf;
        public const ushort SCSecondPassCheckOverFailedPacket = 0x247;
        public const ushort SCSecondPassAccountLockedPacket = 0x139;
        public const ushort SCUnknownPacket_0x1ac = 0x1ac;
        public const ushort SCScheduleItemUpdatePacket = 0x219;
        public const ushort SCScheduledEventStartedPacket = 0x01c;
        public const ushort SCScheduledEventEndedPacket = 0x1de;
        public const ushort SCMouldListPacket = 0x1be;
        public const ushort SCMouldAskedPacket = 0x242;
        public const ushort SCMouldTakenPacket = 0x11c;
        public const ushort SCToggleBeautyshopResponsePacket = 0x046;
        public const ushort SCSpecialtyCurrentPacket = 0x17f;
        public const ushort SCUnitIdleStatusPacket = 0x170;
        public const ushort SCRaceCondPacket = 0x1fb;
        public const ushort SCRacingPacket = 0x14b;
        public const ushort SCRacingResultPacket = 0x1ae;
        public const ushort SCRankRewardMailPacket = 0x130;
        public const ushort SCRankCharacterPacket = 0x21b;
        public const ushort SCRankSnapshotPacket = 0x052;
        public const ushort SCUnknownPacket_0x22c = 0x22c;
        public const ushort SCUnknownPacket_0x213 = 0x213;
        public const ushort SCUnknownPacket_0x1ab = 0x1ab;
        public const ushort SCUnknownPacket_0x150 = 0x150;
        public const ushort SCUnknownPacket_0x184 = 0x184;
        public const ushort SCUnknownPacket_0x08d = 0x08d;
        public const ushort SCUpdatePremiumPointPacket = 0x065;
        public const ushort SCPremiumPointChangedPacket = 0x15e;
        public const ushort SCUnitGmModeChangedPacket = 0x1bd;
        public const ushort SCUnitPvPPointsChangedPacket = 0x126;
        public const ushort SCRankAlarmPacket = 0x07f;
        public const ushort SCICSExchangeRatioPacket = 0x097;
        public const ushort SCPremiumServiceListPacket = 0x230;
        public const ushort SCUnknownPacket_0x225 = 0x225;
        public const ushort SCUnknownPacket_0x200 = 0x200;
        public const ushort SCUnknownPacket_0x0b3 = 0x0b3;
        public const ushort SCUnknownPacket_0x259 = 0x259;
        public const ushort SCUnknownPacket_0x01e = 0x01e;
        public const ushort SCUnknownPacket_0x0d6 = 0x0d6;
        public const ushort SCUnknownPacket_0x04f = 0x04f;
        public const ushort SCCharacterAddStatPacket = 0x03f;
        public const ushort SCUnlockCurrencySlotPacket = 0x22d;
        public const ushort SCUnknownPacket_0x1bc = 0x1bc;
        public const ushort SCUnknownPacket_0x18b = 0x18b;
        public const ushort SCUnknownPacket_0x205 = 0x205;
        public const ushort SCUnknownPacket_0x0c2 = 0x0c2;
        public const ushort SCUnknownPacket_0x1f4 = 0x1f4;
        public const ushort SCUnknownPacket_0x035 = 0x035;
        public const ushort SCUnknownPacket_0x0c6 = 0x0c6;
        public const ushort SCAccountAttributeKindPacket = 0x245;
        public const ushort SCAccountAttributeConfigPacket = 0x14c;
        public const ushort SCIdleKickPacket = 0x25a;
        public const ushort SCUnknownPacket_0x0de = 0x0de;
        public const ushort SCUnknownPacket_0x24d = 0x24d;
        public const ushort SCUnknownPacket_0x179 = 0x179;
        public const ushort SCUnknownPacket_0x012 = 0x012;
        public const ushort SCUnknownPacket_0x1b0 = 0x1b0;
        public const ushort SCUnknownPacket_0x19b = 0x19b;
        public const ushort SCUnknownPacket_0x06a = 0x06a;
        public const ushort SCUnknownPacket_0x0a9 = 0x0a9;
        public const ushort SCUnknownPacket_0x0ab = 0x0ab;
        public const ushort SCUnknownPacket_0x092 = 0x092;
        public const ushort SCUnknownPacket_0x0ba = 0x0ba;
        public const ushort SCUnknownPacket_0x232 = 0x232;
        public const ushort SCUnknownPacket_0x011 = 0x011;
        public const ushort SCUnknownPacket_0x1cf = 0x1cf;
        public const ushort SCUnknownPacket_0x06f = 0x06f;
        public const ushort SCUnknownPacket_0x25c = 0x25c;
        public const ushort SCUnknownPacket_0x260 = 0x260;
        public const ushort SCUnknownPacket_0x058 = 0x058;
        public const ushort SCUnknownPacket_0x0ff = 0x0ff;
        public const ushort SCUnknownPacket_0x243 = 0x243;
        public const ushort SCUnknownPacket_0x1fa = 0x1fa;
        public const ushort SCUnknownPacket_0x1a7 = 0x1a7;
        public const ushort SCUnknownPacket_0x106 = 0x106;
        public const ushort SCUnknownPacket_0x15b = 0x15b;
        public const ushort SCUnknownPacket_0x238 = 0x238;
        public const ushort SCUnknownPacket_0x137 = 0x137;
        public const ushort SCUnknownPacket_0x250 = 0x250;
        public const ushort SCUnknownPacket_0x0e9 = 0x0e9;
        public const ushort SCCharacterPortalsPacket = 0x1d0;
        public const ushort SCCharacterReturnDistrictsPacket = 0x24a;
        public const ushort SCCharacterLaborPowerChangedPacket = 0x1f2;
        public const ushort SCCharacterBounPacket = 0x17d;
        public const ushort SCKnockBackUniPacket = 0x074;
        public const ushort SCItemDetailUpdatePacket = 0x178;
        public const ushort SCUnitEquipmentsChangedPacket = 0x0be;
        public const ushort SCCofferContentsUpdatPacket = 0x20a;
        public const ushort SCItemAcquisitioPacket = 0x0ad;
        public const ushort SCGradeEnchantResulPacket = 0x246;
        public const ushort SCGradeEnchantBroadcasPacket = 0x068;
        public const ushort SCCvFCombatRelationshipPacket = 0x076;
        public const ushort SCFvFCombatRelationshipPacket = 0x062;
        public const ushort SCChatSpamDelayPacket = 0x124;
        public const ushort SCTeamMemberDisconnectedPacket = 0x0b4;
        public const ushort SCUnknownPacket_0x16a = 0x16a;
        public const ushort SCUnknownPacket_0x09e = 0x09e;
        public const ushort SCUnknownPacket_0x01f = 0x01f;
        public const ushort SCUnknownPacket_0x00d = 0x00d;
        public const ushort SCUnknownPacket_0x0ea = 0x0ea;
        public const ushort SCUnknownPacket_0x1e3 = 0x1e3;
        public const ushort SCLootDicePacket = 0x107;
        public const ushort SCLootDiceNotifyPacket = 0x174;
        public const ushort SCDoodadCreatedPacket = 0x05f;
        public const ushort SCDoodadsCreatedPacket = 0x09a;
        public const ushort SCMailBodyPacket = 0x155;
        public const ushort SCMateEquipmentChangedPacket = 0x025;
        public const ushort SCSoldItemListPacket = 0x0b7;
        public const ushort SCAuctionPostedPacket = 0x090;
        public const ushort SCAuctionCanceledPacket = 0x251;
        public const ushort SCPlotEventPacket = 0x08b;
        public const ushort SCActabilityPacket = 0x23e;
        public const ushort SCGimmicksCreatedPacket = 0x223;
        public const ushort SCWorldAABBPacket = 0x042;
        public const ushort SCGmDumpEquipmentPacket = 0x045;
        public const ushort SCUnknownPacket_0x229 = 0x229;
        public const ushort SCUnknownPacket_0x0c3 = 0x0c3;
        public const ushort SCPortalInfoSavedPacket = 0x1d3;
        public const ushort SCOtherTradeItemPutupPacket = 0x203;
        public const ushort SCOtherTradeItemTookdownPacket = 0x167;
        public const ushort SCLoadInstancePacket = 0x1e0;
        public const ushort SCResponseCommonFarmListPacket = 0x0e8;
        public const ushort SCTransferTelescopeUnitsPacket = 0x01d;
        public const ushort SCUnknownPacket_0x02d = 0x02d;
        public const ushort SCSchoolOfFishDoodadsPacket = 0x16b;
        public const ushort SCAiDebugPacket = 0x244;
        public const ushort SCAiAggroPacket = 0x264;
        public const ushort SCCharacterGenderAndModelModifiedPacket = 0x0bb;
        //public const ushort SCAccountAttributeKindPacket = 0x24f;
        //public const ushort SCAccountAttributeKindPacket = 0x1c2;
        public const ushort SCUnknownPacket_0x21d = 0x21d;
        public const ushort SCUnknownPacket_0x0a1 = 0x0a1;
        public const ushort SCCreateCharacterResponsePacket = 0x1a5;
        public const ushort SCEditCharacterResponsePacket = 0x19e;
        public const ushort SCCharacterListPacket = 0x078;
        public const ushort SCSlaveEquipmentChangedPacket = 0x181;
        public const ushort SCOneUnitMovementPacket = 0x1dd;
        public const ushort SCUnitImpulsePacket = 0x1ad;
        public const ushort SCItemTaskNotifyPacket = 0x0e4;
        public const ushort SCMyHouseStatePacket = 0x146;
        public const ushort SCHouseTaxInfoPacket = 0x00f;
        public const ushort SCConstructHouseTaxPacket = 0x09f;
        public const ushort SCHouseSetForSalePacket = 0x023;
        public const ushort SCJoinedTeamPacket = 0x167;
        public const ushort SCTeamLootingRuleChangedPacket = 0x077;
        public const ushort SCSiegeStatePacket = 0x05e;
        public const ushort SCQuestsPacket = 0x0e2;
        public const ushort SCLootBagDataPacket = 0x206;
        public const ushort SCGotMailPacket = 0x0f6;
        public const ushort SCChargeMoneyPaidPacket = 0x053;
        public const ushort SCAuctionSearchedPacket = 0x1da;
        public const ushort SCAuctionLowestPricePacket = 0x236;
        public const ushort SCAuctionMessagePacket = 0x034;
        public const ushort SCGimmickMovementPacket = 0x093;
        public const ushort SCQuestContextStartedPacket = 0x212;
        public const ushort SCQuestContextUpdatedPacket = 0x136;
        public const ushort SCGmDumpQuestsPacket = 0x032;
        public const ushort SCGmDumpNpcPacket = 0x044;
        public const ushort SCUnknownPacket_0x154 = 0x154;
        public const ushort SCUnknownPacket_0x038 = 0x038;
        public const ushort SCUnknownPacket_0x0d1 = 0x0d1;
        public const ushort SCUnknownPacket_0x1b3 = 0x1b3;
        public const ushort SCTradeMoneyPutupPacket = 0x23a;
        public const ushort SCOtherTradeMoneyPutupPacket = 0x109;
        public const ushort SCTradeMadePacket = 0x249;
        public const ushort SCShipyardStatePacket = 0x16e;
        public const ushort SCCharDetailPacket = 0x041;
        public const ushort SCLoginCharInfoHousePacket = 0x037;
        public const ushort SCTelescopeUnitsPacket = 0x1e1;
        public const ushort SCDominionDataPacket = 0x0bc;
        public const ushort SCUnitMovementsPacket = 0x02b;
        public const ushort SCItemTaskSuccessPacket = 0x1b5;
        public const ushort SCUnitBountyMoneyPacket = 0x1d5;
        public const ushort SCHouseStatePacket = 0x100;
        public const ushort SCUnknownPacket_0x1c8 = 0x1c8;
        public const ushort SCSetBountyPermittedPacket = 0x1cb;
        public const ushort SCSetBountyDonePacket = 0x159;
        public const ushort SCBountyPaidPacket = 0x1a9;
        public const ushort SCUnitStatePacket = 0x071;
        public const ushort SCUnknownPacket_0x221 = 0x221;
        public const ushort SCCharacterStatePacket = 0x224;

        // no such packets
        public const ushort SCAccountAttendancePacket = 0xfff;
        public const ushort SCSkillUpgradedPacket = 0xfff;
        public const ushort SCSlaveCreatedPacket = 0xfff;
        public const ushort SCTeamPingPosPacket = 0xfff;
        public const ushort SCUnknownPacket = 0xfff;
        public const ushort SCDominionDeletedPacket = 0xfff;
        public const ushort SCHouseBuildPayChangedPacket = 0xfff;
        public const ushort SCGamePointChangedPacket = 0xfff;
        public const ushort SCGradeEnchantBroadcastPacket = 0xfff;
        public const ushort SCGradeEnchantResultPacket = 0xfff;
        public const ushort SCKnockBackUnitPacket = 0xfff;
        public const ushort SCLevelRestrictionConfigPacket = 0xfff;
    }
}
