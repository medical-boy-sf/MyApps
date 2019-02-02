function bitConverver(c1,c2,s1) {
    let s2;
    if (c1 === 'bytes') {
        if(c2 === 'KB') {
            s2 = s1 / 1024;
            return `${s1} ${c1} = ${s2} ${c2}`;
        } else if (c2 === 'MB') {
            s2 = s1 / Math.pow(1024, 2);
            return `${s1} ${c1} = ${s2} ${c2}`;
        } else if (c2 === 'GB') {
            s2 = s1 / Math.pow(1024, 3);
            return `${s1} ${c1} = ${s2} ${c2}`;
        }
    } else if (c1 === 'KB') {
        if (c2 === 'bytes') {
            s2 = s1 * 1024;
            return `${s1} ${c1} = ${s2} ${c2}`;
        } else if (c2 === 'MB') {
            s2 = s1 / 1024;
            return `${s1} ${c1} = ${s2} ${c2}`;
        } else if (c2 === 'GB') {
            s2 = s1 / Math.pow(1024, 2);
            return `${s1} ${c1} = ${s2} ${c2}`;
        }
    } else if (c1 === 'MB') {
        if (c2 === 'bytes') {
            s2 = s1 * Math.pow(1024, 2);
            return `${s1} ${c1} = ${s2} ${c2}`;
        } else if (c2 === 'KB') {
            s2 = s1 * 1024;
            return `${s1} ${c1} = ${s2} ${c2}`;
        } else if (c2 === 'GB') {
            s2 = s1 / 1024;
            return `${s1} ${c1} = ${s2} ${c2}`;
        }
    } else if (c1 === 'GB') {
        if (c2 === 'bytes') {
            s2 = s1 * Math.pow(1024, 3);
            return `${s1} ${c1} = ${s2} ${c2}`;
        } else if (c2 === 'KB') {
            s2 = s1 * Math.pow(1024, 2);
            return `${s1} ${c1} = ${s2} ${c2}`;
        } else if (c2 === 'MB') {
            s2 = s1 * 1024;
            return `${s1} ${c1} = ${s2} ${c2}`;
        }
    }

}