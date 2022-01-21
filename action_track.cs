

class SecondClip
{
    path = Position[24];
    actions = Actions[24];
}

class Track
{
    // 帧开始的时间, 从0开始计算
    int startTimeIndex = 0;
    // 片段时间长度
    int trackTimeLength = 0;
    // 快进或者慢放速度
    float speed = 1;
    track = Vector<SecondClip>();

}

