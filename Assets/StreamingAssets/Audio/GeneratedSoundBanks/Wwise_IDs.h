/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID PLAY_DRAGON_ATTACK = 3988252362U;
        static const AkUniqueID PLAY_DRAGONBASE = 1262362028U;
        static const AkUniqueID PLAY_FOOTSTEPSPLAYER = 1599135344U;
        static const AkUniqueID PLAY_HEAVYFOOTSTEP = 1580937561U;
        static const AkUniqueID PLAY_LIGHTFOOTSTEP = 4260766568U;
        static const AkUniqueID STOP_FOOTSTEPSPLAYER = 3009817362U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace DRAGONSTATE
        {
            static const AkUniqueID GROUP = 3420125775U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID PATROLLING = 2799695215U;
                static const AkUniqueID RAGE = 1942738266U;
            } // namespace STATE
        } // namespace DRAGONSTATE

        namespace PLAYERLOCATION
        {
            static const AkUniqueID GROUP = 1602053271U;

            namespace STATE
            {
                static const AkUniqueID BOSSROOM = 3329270527U;
                static const AkUniqueID HALLWAY1 = 4053971346U;
                static const AkUniqueID HALLWAY2 = 4053971345U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID SPAWN = 71202558U;
            } // namespace STATE
        } // namespace PLAYERLOCATION

    } // namespace STATES

    namespace SWITCHES
    {
        namespace DRAGONSTATE
        {
            static const AkUniqueID GROUP = 3420125775U;

            namespace SWITCH
            {
                static const AkUniqueID PATROLLING = 2799695215U;
                static const AkUniqueID RAGE = 1942738266U;
            } // namespace SWITCH
        } // namespace DRAGONSTATE

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID MASTERBUS = 835198467U;
        static const AkUniqueID MUSICBUS = 2886307548U;
        static const AkUniqueID SFXBUS = 3803850708U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAINSOUNDBANK = 534561221U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
