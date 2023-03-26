import { CanceledError } from "axios";
import { useEffect, useState } from "react";
import apiClient from "../services/apiClient";


const useData = (endpoint, requestConfig = null, deps = null) => {
    const [data, setData] = useState(null);
    const [error, setError] = useState(null);
    const [loading, setLoading] = useState(false);

    useEffect(() => {
        const controller = new AbortController();

        setLoading(true);
        apiClient
            .get(endpoint, { signal: controller.signal, ...requestConfig })
            .then((res) => {
                setData(res.data);
                setLoading(false);
            })
            .catch((err) => {
                if (err instanceof CanceledError) return;
                setError(err.message)
                setLoading(false);
            });

        return () => controller.abort();
    }, deps ? [...deps] : []);

    return { data, error, loading };
};

export default useData;