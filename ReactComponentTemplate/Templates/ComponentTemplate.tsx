import React from 'react';$if$($scss$ == 1)

import './$safeitemname$.scss';$endif$$if$($props$ == 1)

export type $safeitemname$Props = {

}

const $safeitemname$: React.FC<$safeitemname$Props> = () => {$else$

const $safeitemname$: React.FC = () => {$endif$
    return (
        <div$if$ ($scss$ == 1) className="$bemname$"$endif$></div>
    );
}

$safeitemname$.displayName = '$safeitemname$';

export default React.memo($safeitemname$);